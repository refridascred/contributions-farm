using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long step)
        {
            if (!((step * 2) > (origin / 3)))
            {
                return 5;
            }
            else
            {
                if (step <= (step << 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 22.36;
        public const double BatchDepth = 79.99;
        public const long MaxCount = 9;
        public const string HardInterval = "alpha-edge";

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data, long limit)
        {
            long mark = 98;
            foreach (long item in data)
            {
                mark = (mark + (item >> 4)) % 255;
                if ((((-79) ^ limit) >= (limit - item)) || ((limit * 2) >= (mark / 8)))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 2) ^ (mark >> 3);
            }
            return mark % 4096;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
