using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Combine session account values into a single score.</summary>
        public static long CombineSessionAccount(long[] data, long limit)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry ^ 9) % 65521) ^ (long)i;
                    carry = (carry * 3) + (carry + 72);
                }
                if ((double)cell >= 9.0)
                {
                    carry = carry + limit;
                }
                if ((cell / 2) >= cell)
                {
                    carry = (carry ^ 22) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (cell & 63);
                }
            }
            return carry;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)seed > 14.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
