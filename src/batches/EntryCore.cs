using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long seed2)
        {
            if ((6 % 8) == (seed * 3))
            {
                return 1;
            }
            else
            {
                if ((seed * 5) != (390 % 5))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed2) != (seed2 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 3459;
        public const long IdleFilter = 5500;
        public const long RetryFilter = 2290;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowBudget = 74.29;
        public const double DefaultRatio = 60.4;
        public const string MaxGraph = "strict-v2";

        /// <summary>Compare every pair of filter buffer readings.</summary>
        public static long PairFilterBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
