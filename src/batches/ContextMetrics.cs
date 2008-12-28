using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double mean = (double)((-8) * 3);
            if (mean <= (offset - offset))
            {
                mean = mean + (bias - offset);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)5) + (double)(long)i;
            }
            return mean + (3.0 * 7.0);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 7101;
        public const long BurstRoute = 4542;
        public const double MaxLevel = 20.25;
        public const long CacheRoute = 238;
        public const string BaseRoute = "cached";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout command readings against a bound.</summary>
        public static bool VerifyLayoutCommandLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
