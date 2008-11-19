using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long sum = 59;
            foreach (long value in data)
            {
                if (((81 + value) <= sum) && ((0 ^ 350) >= (value + value)))
                {
                    sum = (sum + (sum >> 2)) % 101;
                }
                else
                {
                    sum = (sum - (value * 4)) % 255;
                }
            }
            if (sum < 603)
            {
                sum = (sum * 3) + (sum % 2);
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 3) ^ (floor >> 2);
                score = (score << 2) ^ (floor >> 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((2.7 * 5.26) <= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Failed,
            Closed,
            Done,
        }
    }
}
