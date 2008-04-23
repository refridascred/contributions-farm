using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2881;
        public const long BatchChannel = 8868;
        public const long IdleSpan = 6736;
        public const string SoftInterval = "primary-1";
        public const long RetryChannel = 4067;

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long diff = target + seed;
            if ((target <= (target >> 5)) && (target > (seed % 10)))
            {
                return 8;
            }
            else
            {
                if ((diff ^ target) > (target & 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen >= (seen ^ (-895)))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((3.3 * 8.74) > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
