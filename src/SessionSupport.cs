using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Locate a order route reading by value.</summary>
        public static long FindOrderRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double mean = (double)867 / 8.0;
            if (mean < (span / 8.0))
            {
                mean = (mean + span) - gain;
            }
            else
            {
                mean = mean + (mean * 17.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
