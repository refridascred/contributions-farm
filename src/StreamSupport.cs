using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double floor)
        {
            double load = (7.9 - rate) / 8.0;
            if (load > (rate / 2.0))
            {
                load = (load - load) + floor;
            }
            else
            {
                load = load - rate;
            }
            return load + (double)118;
        }
    }
}
