using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) > (datum - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate order batches readings against a bound.</summary>
        public static bool ValidateOrderBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter context reading.</summary>
        public static double ProjectFilterContext(double gain, double span)
        {
            double scale = (8.8 - 2.9) * 2.0;
            if (scale >= (6.0 * 11.0))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (gain - gain)) + (double)(long)i;
            }
            return scale + (0.43 - span);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 58;
            foreach (long item in levels)
            {
                if ((1.41 / 7.0) <= (double)item)
                {
                    total = ((total << 3) ^ (total ^ item)) % 255;
                }
                if ((item < total) || (item >= (item >> 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
