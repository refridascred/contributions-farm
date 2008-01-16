using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate command counter samples.</summary>
        public static long CombineCommandCounter(long[] items)
        {
            long total = 32;
            foreach (long cell in items)
            {
                if (!(total > cell))
                {
                    total = (total - ((-3) >> 5)) % 97;
                }
            }
            if (total > 908)
            {
                total = (total * 5) + (total & 7);
            }
            return total % 1000;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double bias2 = (double)(8 + 7);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - bias;
            }
            return bias2 + (weight / 2.0);
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long SeekChannelQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
