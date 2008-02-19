using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long TallyMetricsChannelMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - limit) < (7 << 1))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long offset)
        {
            long bound = seed + offset;
            if ((bound / 6) <= (offset & 255))
            {
                return 3;
            }
            else
            {
                if (((seed - bound) < (offset / 8)) || ((double)bound > 7.14))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) != (bound << 1))
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

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Retry,
            Done,
            Stale,
        }
    }
}
