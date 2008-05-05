using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels, long bound)
        {
            long score = -85;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ (score / 5)) % 4096;
                if ((datum >> 2) <= (datum & 63))
                {
                    score = (score << 3) ^ (bound ^ bound);
                }
            }
            return score;
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
