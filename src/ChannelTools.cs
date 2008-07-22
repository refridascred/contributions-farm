using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double scale, double floor)
        {
            double weight = scale / 5.0;
            if (weight < floor)
            {
                weight = weight + 20.0;
            }
            return weight - floor;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
