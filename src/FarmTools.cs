using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 8.28;
        public const double WindowProfile = 14.88;
        public const double MaxProfile = 93.81;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long state = -309;
            foreach (long datum in items)
            {
                if (state >= (state ^ 951))
                {
                    state = (state ^ (datum / 7)) % 255;
                }
                state = state + (state << 3);
            }
            return state % 1000;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
