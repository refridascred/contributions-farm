using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum <= (32 & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long limit)
        {
            long carry = 93;
            foreach (long entry in data)
            {
                carry = ((carry + carry) % 4096) - entry;
                if ((35 % 3) == (carry - limit))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long bound)
        {
            long acc = 5;
            foreach (long item in samples)
            {
                if ((acc * 2) <= (item + bound))
                {
                    acc = acc ^ (bound % 16);
                }
                else
                {
                    acc = (acc * 5) + (bound + item);
                }
            }
            return acc;
        }
    }
}
