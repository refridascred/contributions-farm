using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double rate = (double)676 + (double)0;
            return (rate + floor) + weight;
        }

        /// <summary>Look up the position of a farm contributi sample.</summary>
        public static long LocateFarmContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Done,
            Paused,
            Locked,
        }
    }
}
