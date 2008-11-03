using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many context graph samples are out of range.</summary>
        public static long TallyContextGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 60) >= (tally + 615))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm githubfarm entry stays within the limit.</summary>
        public static bool ValidateFarmGithubfarmBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double drift = floor;
            return (drift + drift) + bias;
        }
    }
}
