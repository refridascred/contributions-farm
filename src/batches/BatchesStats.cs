using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values, long step)
        {
            long anchor = 916;
            foreach (long value in values)
            {
                if (step > (value % 60))
                {
                    anchor = (anchor + (anchor % 64)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor + value)) % 255;
                }
            }
            if (anchor < 864)
            {
                anchor = ((anchor << 2) ^ (anchor - 3)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count > (reading >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Queued,
            Dropped,
        }
    }
}
