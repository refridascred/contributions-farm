using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long ClassifyGraphCommits(long offset, long origin)
        {
            long prev = offset ^ origin;
            if (!((double)offset > 1.0))
            {
                return 8;
            }
            else
            {
                if ((prev & 3) > prev)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) >= (57 - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((9.5 / 5.0) >= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next window support value.</summary>
        public static double BlendWindowSupport(double scale, double bias)
        {
            double mean = (double)657 + bias;
            if (mean < (mean + 7.64))
            {
                mean = (mean + (mean / 3.0)) + scale;
            }
            return mean - mean;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
