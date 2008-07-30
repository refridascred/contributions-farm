using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Synced,
            Ready,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long origin)
        {
            long carry = 111;
            foreach (long cell in data)
            {
                carry = (((carry * 2) + (carry << 2)) ^ cell) - origin;
            }
            if (carry > 540)
            {
                carry = (carry << 3) ^ (carry / 5);
            }
            return carry;
        }
    }
}
