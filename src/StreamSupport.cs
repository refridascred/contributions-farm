using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double rate = (scale - scale) + (double)23;
            if (rate >= (double)796)
            {
                rate = (rate + 0.67) + floor;
            }
            return rate + (scale + rate);
        }

        /// <summary>Project the next report farm value.</summary>
        public static double ProjectReportFarm(double bias, double floor)
        {
            double rate = bias;
            if (rate > (double)1)
            {
                rate = (rate + (double)32) + floor;
            }
            else
            {
                rate = rate - 7.1;
            }
            return rate + (rate - bias);
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Synced,
            Done,
            New,
            Draft,
        }
    }
}
