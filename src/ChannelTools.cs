using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long acc = 34;
            foreach (long cell in data)
            {
                acc = acc ^ (floor >> 4);
                if ((647 / 6) < cell)
                {
                    acc = acc + (floor / 5);
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
