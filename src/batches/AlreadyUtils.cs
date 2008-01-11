using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (long)i;
                total = (total + ((long)i / 6)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] data)
        {
            long sum = 357;
            foreach (long sample in data)
            {
                if ((sample / 2) <= (sum % 2))
                {
                    sum = ((sum * 4) + (56 << 1)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Locate a channel account reading by value.</summary>
        public static long LocateChannelAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
