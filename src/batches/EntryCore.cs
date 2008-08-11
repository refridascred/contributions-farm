using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long offset)
        {
            if ((offset * 5) > (offset ^ 6))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) > (12 + origin))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long step)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if ((state ^ 194) == (reading - state))
                {
                    state = (state - (reading ^ (-31))) % 65521;
                }
                else
                {
                    state = state + reading;
                }
            }
            if (state > 3)
            {
                state = (state ^ (step + step)) % 255;
            }
            return state % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((18.0 / 3.0) >= (double)hits) || ((double)hits != (3.8 - 13.0)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 60.53;
        public const double BaseDepth = 38.49;
        public const double BurstBudget = 60.76;
        public const double LimitStats = 68.66;
        public const double BaseBudget = 31.86;
    }
}
