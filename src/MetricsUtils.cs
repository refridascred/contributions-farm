using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long floor)
        {
            long mix = 839;
            foreach (long sample in data)
            {
                if (((sample - 306) < floor) && ((sample + floor) < (sample % 100)))
                {
                    mix = mix + (floor << 3);
                }
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally & 7) <= (item % 16))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema profile values into a single score.</summary>
        public static long WeighSchemaProfile(long[] levels, long step)
        {
            long acc = 303;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (acc % 16)) + sample) + step;
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ (3 + 171)) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
