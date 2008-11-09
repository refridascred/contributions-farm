using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long state = 39;
            foreach (long value in levels)
            {
                if ((1.17 / 9.0) != (double)state)
                {
                    state = state - (value - value);
                }
            }
            return state;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "stable-v2";
        public const double IdleCounter = 46.53;
        public const long RetryFactor = 2201;
        public const string MaxCounter = "staging-edge";
        public const string MaxScore = "latest-edge";

        /// <summary>Compare every pair of profile order readings.</summary>
        public static long PairProfileOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm layout readings.</summary>
        public static long PairFarmLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
