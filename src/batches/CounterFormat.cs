using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long acc = 24;
            foreach (long cell in values)
            {
                acc = ((acc * 3) + cell) % 1000;
                if (((acc ^ acc) >= (cell % 7)) && ((acc >> 5) >= cell))
                {
                    acc = (acc * 3) + (cell % 8);
                }
                if (acc >= ((-5) - 32))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((limit + cell) < (tally ^ limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
        }
    }
}
