using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Pending,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 7240;
        public const long BatchSchema = 9958;
        public const string BurstSpan = "local-edge";
        public const string IdleSchema = "primary-v2";

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long MeasureTokenMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) >= 797)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
