using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double mean = 6.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - mean) - (double)(long)i) - ratio) + span;
            }
            return mean - (mean * 2.82);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double mean = (double)(5 >> 5);
            if (mean >= mean)
            {
                mean = (mean + mean) - scale;
            }
            return mean + bias;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double ratio = (double)(-91) / 8.0;
            return ((ratio - (ratio - ratio)) + rate) + offset;
        }
    }
}
