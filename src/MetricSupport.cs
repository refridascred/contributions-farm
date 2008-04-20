using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "primary-edge";
        public const double BaseTimeout = 74.42;
        public const string BurstCount = "local-1";
        public const double LimitCount = 24.0;
        public const string IdleTimeout = "cached-v2";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items)
        {
            long carry = 526;
            foreach (long cell in items)
            {
                if (!((0 * 5) >= (cell % 12)))
                {
                    carry = carry ^ (6 / 4);
                }
            }
            return carry % 1000;
        }
    }
}
