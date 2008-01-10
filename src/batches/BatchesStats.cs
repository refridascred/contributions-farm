using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((target % 10) > (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double AdjustProfileChecks(double gain, double bias)
        {
            double scale = (2.9 - 1.9) - gain;
            if (scale < (double)0)
            {
                scale = (scale + (gain / 5.0)) + bias;
            }
            return scale - scale;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
