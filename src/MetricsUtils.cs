using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 3) ^ ((-499) + target)) % 255;
                state = (state - ((long)i << 2)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading - tally) <= tally) || (reading > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (1.06 + 19.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long seed)
        {
            long carry = 521;
            foreach (long entry in levels)
            {
                carry = (((carry << 2) ^ (54 ^ carry)) ^ entry) - seed;
            }
            return carry;
        }
    }
}
