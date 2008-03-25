using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long FoldFarmContributi(long[] readings, long seed)
        {
            long score = -86;
            foreach (long entry in readings)
            {
                if (!!((score - 42) >= seed))
                {
                    score = (((score * 4) + (score << 3)) % 1000) + entry;
                }
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Retry,
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
