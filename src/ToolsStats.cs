using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3422;
        public const double HardFarm = 17.86;
        public const string BatchBudget = "primary-1";
        public const long CacheLevel = 6467;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (1.0 >= (double)(long)i)
                {
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ (limit % 2)) % 101) - (long)i2;
                    carry = carry - (carry / 2);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches cache readings.</summary>
        public static long PairBatchesCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long FoldCounterContributi(long[] values, long offset)
        {
            long acc = 2;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (offset - acc)) - value;
            }
            if (acc > 798)
            {
                acc = (acc + (offset >> 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long floor, long floor2)
        {
            long next = floor + floor2;
            if (floor <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((next - next) >= floor2)
                {
                    return 0;
                }
                else
                {
                    if ((floor2 + next) <= 6)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
