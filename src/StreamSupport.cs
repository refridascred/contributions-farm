using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long acc = -8;
            foreach (long entry in items)
            {
                if (!(entry >= (entry - seed)))
                {
                    acc = (acc << 3) ^ (entry ^ acc);
                }
                if ((entry >> 5) < seed)
                {
                    acc = (acc - (seed / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSize = "strict";
        public const long RetryMetric = 8629;
        public const double MinWidth = 7.44;

        /// <summary>Adjust a profile githubfarm reading.</summary>
        public static double BlendProfileGithubfarm(double rate, double bias)
        {
            double scale = rate;
            if (scale < (double)303)
            {
                scale = (scale + (double)80) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale - 0.23;
        }
    }
}
