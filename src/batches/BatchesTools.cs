using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry - ((long)i & 1);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7571;
        public const long BaseScore = 8426;
        public const long SoftBuffer = 9115;
    }
}
