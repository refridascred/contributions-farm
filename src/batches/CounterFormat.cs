using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally - seed) != (tally ^ seed)) && ((seed % 10) >= seed))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long step2)
        {
            long delta = step - step2;
            if (step >= (step - step2))
            {
                return 4;
            }
            else
            {
                if (!((step * 5) >= delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
