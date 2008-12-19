using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (136 >= (origin - (-583)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long TallyNotesBatch(long[] series, long offset)
        {
            long state = 629;
            foreach (long value in series)
            {
                if (offset >= (state >> 1))
                {
                    state = state - (9 - value);
                }
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data)
        {
            long result = 828;
            foreach (long datum in data)
            {
                if (!((double)datum == (20.0 * 7.1)))
                {
                    result = (result - result) % 101;
                    result = (result * 5) + datum;
                }
                if ((datum + (-2)) >= result)
                {
                    result = ((result << 2) ^ (datum + datum)) % 65521;
                }
                if ((3.6 + 3.0) > (double)datum)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long CombineOrderChecks(long[] levels, long bound)
        {
            long mix = 25;
            foreach (long sample in levels)
            {
                if ((bound >= (sample << 1)) || (bound < ((long)levels.Length ^ sample)))
                {
                    mix = (mix ^ (4 >> 4)) % 101;
                }
                else
                {
                    mix = (mix + (94 * 4)) % 4096;
                }
                if ((16 + bound) < (bound / 2))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
