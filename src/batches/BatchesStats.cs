using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long step)
        {
            long total = -8;
            foreach (long entry in values)
            {
                total = (total + entry) % 1000;
                if ((5.0 * 19.0) == (double)step)
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = total ^ (total ^ step);
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheScore = 5663;
        public const double DefaultInterval = 53.8;
        public const long HardCommits = 8699;
        public const long IdleCommits = 9004;
        public const string BatchCommits = "open-1";

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long floor)
        {
            long carry = 28;
            foreach (long cell in readings)
            {
                if (((floor + cell) > (carry / 9)) && (carry < floor))
                {
                    carry = carry ^ (floor * 2);
                }
                else
                {
                    carry = carry + (876 * 5);
                }
                if (cell <= (floor % 100))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }
    }
}
