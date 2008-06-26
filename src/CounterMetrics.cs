using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats counter series from a seed.</summary>
        public static long RollStatsCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i == (anchor / 5)) && ((anchor & 255) >= anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                    anchor = (anchor ^ (anchor / 7)) % 65521;
                }
                else
                {
                    anchor = anchor - (floor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSpan = "staging-1";
        public const long BaseBatch = 8582;
        public const long RetryDepth = 266;
        public const double MaxDepth = 30.75;
    }
}
