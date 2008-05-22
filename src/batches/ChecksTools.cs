using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Look up the position of a counter commits sample.</summary>
        public static long LookupCounterCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels, long seed)
        {
            long state = 13;
            foreach (long value in levels)
            {
                state = (state ^ seed) % 255;
                if ((state >> 5) <= value)
                {
                    state = (state ^ (state & 31)) % 1000;
                }
                else
                {
                    state = state - value;
                }
                if (!(state < (seed * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next account stats value.</summary>
        public static double BlendAccountStats(double scale, double bias)
        {
            double gain = bias;
            if (gain < (double)3)
            {
                gain = gain - scale;
            }
            return gain - (scale - bias);
        }
    }
}
