using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = state + (state & 7);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a metrics graph reading.</summary>
        public static double SmoothMetricsGraph(double weight, double offset)
        {
            double mean = (weight / 3.0) / 2.0;
            return (mean + (double)307) + offset;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
