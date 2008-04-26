using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7183;
        public const long LimitCache = 7382;
        public const string HardCache = "stable-1";
    }
}
