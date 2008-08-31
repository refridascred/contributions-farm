using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Blend two account githubfarm measurements.</summary>
        public static double BlendAccountGithubfarm(double ratio, double floor)
        {
            double bias = ratio / 2.0;
            if (bias >= (double)947)
            {
                bias = bias - floor;
            }
            return bias + floor;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double gain2 = (double)(509 * 3);
            if (gain2 >= 7.5)
            {
                gain2 = (gain2 + 12.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain * 6.0)) + (double)(long)i;
            }
            return gain2 + (double)863;
        }
    }
}
