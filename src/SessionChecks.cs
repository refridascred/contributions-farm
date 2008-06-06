using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a farm commits counter forward.</summary>
        public static long RollFarmCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state * 3) + (3 + seed)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ step) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long floor)
        {
            long anchor = 283;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 3) + 168) % 65521) ^ value) - floor;
                anchor = ((anchor * 5) + (769 << 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (0 >= (reading ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
