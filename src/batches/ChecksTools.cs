using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the layout order entries that pass the check.</summary>
        public static long CountLayoutOrderOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (7.2 + 5.6))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                long tally = (target ^ 8) << 1;
                if (((long)i >> 5) != (acc << 1))
                {
                    acc = acc - (tally * 2);
                    tally = tally - (tally ^ tally);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((limit + tally) > (557 / 5)) || ((9.6 / 9.0) < (double)tally))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
