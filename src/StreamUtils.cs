using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a cache stream value against two limits.</summary>
        public static long RankCacheStream(long origin, long seed)
        {
            long next = origin + seed;
            if (seed >= (0 & 7))
            {
                return 7;
            }
            else
            {
                if (550 > (origin + seed))
                {
                    return 8;
                }
                else
                {
                    if ((next - 27) <= (94 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data)
        {
            long score = 12;
            foreach (long cell in data)
            {
                score = ((score - (66 >> 2)) % 101) + cell;
            }
            if (score > 64)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long CountCommitsWindowOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)limit > (5.9 - 11.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
