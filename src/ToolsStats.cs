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

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardRatio = 1932;
        public const long IdleStats = 2522;
        public const string MaxStats = "cached-v2";
        public const long StepStats = 8580;
        public const long MinStats = 5335;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Dropped,
            Done,
            Locked,
            Retry,
        }
    }
}
