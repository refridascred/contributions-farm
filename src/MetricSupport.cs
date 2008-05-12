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

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (417 + result)) % 255;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (((result << 3) ^ (result ^ bound)) % 65521) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
