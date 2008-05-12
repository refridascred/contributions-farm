using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Queued,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double bias)
        {
            double load = gain;
            if (load < (gain / 4.0))
            {
                load = (load + load) + bias;
            }
            return load - load;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double scale = bias;
            if (scale < (double)166)
            {
                scale = (scale + bias) - rate;
            }
            return scale + (scale * 3.0);
        }
    }
}
