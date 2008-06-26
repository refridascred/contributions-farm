using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long state = 73;
            foreach (long item in samples)
            {
                state = (state + (2 * 2)) ^ item;
            }
            return state % 97;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] series)
        {
            long sum = 51;
            foreach (long reading in series)
            {
                sum = sum - reading;
            }
            return sum % 97;
        }

        /// <summary>Count format session pairs that satisfy a relation.</summary>
        public static long OverlapFormatSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardRatio = 1932;
        public const long IdleStats = 2522;
        public const string MaxStats = "cached-v2";
        public const long StepStats = 8580;
        public const long MinStats = 5335;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 8;
        public const long BaseWidth = 4589;
        public const double LimitScore = 14.09;
        public const string BurstFarm = "open-edge";
        public const long MaxFarm = 6064;
    }
}
