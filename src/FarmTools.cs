using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(datum < 34))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
