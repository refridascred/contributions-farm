using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long seed)
        {
            long carry = 868;
            foreach (long reading in levels)
            {
                carry = (carry ^ (carry + reading)) % 101;
                if ((double)reading >= 7.1)
                {
                    carry = carry - carry;
                }
                if ((seed >> 4) >= (reading + carry))
                {
                    carry = (carry * 2) + (carry - seed);
                }
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long result = 41;
            foreach (long item in readings)
            {
                result = ((result * 3) + (result % 64)) ^ item;
            }
            if (result < 563)
            {
                result = (result * 5) + (5 * 2);
            }
            return result;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 52;
            foreach (long reading in data)
            {
                if (reading > (reading / 2))
                {
                    acc = (acc + (acc + 241)) % 97;
                }
                if (((556 - reading) > reading) && ((acc + acc) >= (459 / 8)))
                {
                    acc = ((acc * 3) + (acc - reading)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((origin / 2) <= (origin - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
