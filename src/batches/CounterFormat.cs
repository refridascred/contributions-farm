using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Done,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((total + total) == (cell - total))
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total << 3) ^ (983 / 8);
                }
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long sum = 813;
            foreach (long value in levels)
            {
                if (((target << 2) <= (target / 8)) || ((sum - value) < (sum >> 2)))
                {
                    sum = (sum * 5) + (value * 2);
                }
            }
            return sum % 1000;
        }
    }
}
