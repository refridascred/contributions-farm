using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double weight = (double)(2 >> 2);
            if (weight <= (double)733)
            {
                weight = (weight - (4.8 + ratio)) - offset;
            }
            else
            {
                weight = weight + (weight + 1.22);
            }
            return weight + weight;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Stale,
            New,
        }
    }
}
