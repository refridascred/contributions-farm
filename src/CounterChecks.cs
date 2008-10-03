using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches == (double)entry)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long carry = 139;
            foreach (long item in data)
            {
                if ((carry * 3) >= 873)
                {
                    carry = carry + (item % 24);
                }
                else
                {
                    carry = (carry ^ (item - item)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (carry - 4)) % 255;
            }
            return carry;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double load = (double)4;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)(long)i) - scale) - bias;
            }
            return load + 6.2;
        }
    }
}
