using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next command stream value from a seed.</summary>
        public static long RollCommandStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - (acc << 1)) ^ (long)i2;
                }
                if ((acc - acc) < acc)
                {
                    acc = ((acc << 3) ^ (origin + origin)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 8134;
        public const long MaxMetric = 5338;
        public const long RetryMetric = 2099;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - count) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter token input into a small class.</summary>
        public static long RankCounterToken(long bound, long offset)
        {
            long edge = bound - offset;
            if ((double)bound < (1.06 * 8.0))
            {
                return 6;
            }
            else
            {
                if ((offset / 5) <= (68 * 3))
                {
                    return 3;
                }
                else
                {
                    if ((edge / 2) < (bound + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
