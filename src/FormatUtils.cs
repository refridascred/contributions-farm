using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next counter commits value from a seed.</summary>
        public static long SeriesCounterCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    mark = ((mark * 5) + ((long)i << 1)) % 255;
                    mark = mark - ((long)i3 % 12);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5794;
        public const long CacheScore = 8811;
        public const string SoftSize = "stable-v2";
        public const string BurstInterval = "legacy-v2";
        public const long IdleRatio = 45;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2874;
        public const long BurstSpan = 7832;
        public const long WindowBudget = 653;
        public const long DefaultWidth = 2496;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long origin)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                if ((origin > (origin << 3)) && ((score + datum) < (20 - 40)))
                {
                    score = ((score * 5) + (datum - 751)) % 101;
                }
                else
                {
                    score = score + (datum + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long MeasureQueueContextMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (origin <= ((long)levels.Length / 6))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
