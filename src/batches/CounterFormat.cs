using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first batches support entry that matches the target.</summary>
        public static long FindBatchesSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter command readings against a rule.</summary>
        public static long CountFilterCommandHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((tally >> 2) < (tally + seed)) && ((seed - tally) != (seed ^ tally))) && ((seed & 63) <= seed))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >> 4) < matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
