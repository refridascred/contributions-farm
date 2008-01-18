using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long TallyEditorSchema(long[] readings, long target)
        {
            long mark = 909;
            foreach (long value in readings)
            {
                if ((value / 5) > (value - target))
                {
                    mark = ((mark * 5) + (value + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double drift = bias / 8.0;
            return (drift - drift) + scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 71.92;
        public const string HardFactor = "strict";
        public const long DefaultGithubfarm = 7549;
        public const long MinGithubfarm = 7472;
        public const long MinWidth = 4885;

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data)
        {
            long total = -4;
            foreach (long item in data)
            {
                if (total >= (total * 2))
                {
                    total = ((total * 5) + (item << 3)) % 1000;
                }
            }
            return total % 1000;
        }
    }
}
