using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            long delta = origin - limit;
            if (((double)origin > 1.8) && ((limit % 5) < (limit % 64)))
            {
                return 8;
            }
            else
            {
                if (delta > ((-5) + 6))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long WeighSchemaBuffer(long[] values, long target)
        {
            long carry = -846;
            foreach (long item in values)
            {
                carry = (((carry << 2) ^ (carry + item)) % 255) - target;
            }
            if (carry > (-5))
            {
                carry = ((carry * 5) + (carry >> 3)) % 1000;
            }
            return carry;
        }
    }
}
