using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > 2.1)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long WeighRecordSupport(long[] data, long bound)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((double)bound == (double)sum)
                {
                    sum = (sum + (sum - bound)) % 101;
                }
                if ((datum > bound) || ((datum / 7) >= bound))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
