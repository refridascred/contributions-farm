using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((6 - (-891)) < (bound << 3)) || ((bound ^ bound) >= bound)) || ((datum * 2) >= bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long floor)
        {
            long step = bound + floor;
            if ((8.3 + 12.0) != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((step / 7) < bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
