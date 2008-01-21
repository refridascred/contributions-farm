using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) < target)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels, long offset)
        {
            long mark = 397;
            foreach (long datum in levels)
            {
                if (!((mark << 2) == (datum + mark)))
                {
                    mark = ((mark * 3) + (datum >> 1)) - offset;
                    mark = ((mark << 3) ^ (mark - mark)) % 101;
                }
                mark = (mark - (datum + datum)) % 4096;
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long offset)
        {
            if ((offset & 15) < (offset * 2))
            {
                return 1;
            }
            else
            {
                if (0 > (floor + offset))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 1.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3 ^ 895) != (floor / 3)) && ((offset + offset) > (offset >> 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support farm samples are out of range.</summary>
        public static long TallySupportFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((379 ^ entry) != (6 >> 3)) || (26 >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
