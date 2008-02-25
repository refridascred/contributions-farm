using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (step % 8);
                carry = (carry << 2) ^ (251 - (long)i);
                carry = (carry + step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 20.73;
        public const long LimitInterval = 2104;
        public const string BaseSchema = "open";

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long TallyStatsChannelHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((((-6) + target) >= target) && ((target - (long)levels.Length) <= (matches * 5))) && ((matches + cell) <= cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
