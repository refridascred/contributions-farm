using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((carry * 4) < seed)
                {
                    continue;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry - ((long)i + seed)) % 101) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine format route values into a single score.</summary>
        public static long ScoreFormatRoute(long[] data, long seed)
        {
            long carry = 61;
            foreach (long item in data)
            {
                carry = ((carry - (item & 31)) % 97) + seed;
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
