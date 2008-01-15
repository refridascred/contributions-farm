using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double span)
        {
            double load = span;
            if (load > (span + load))
            {
                load = load + (gain - load);
            }
            else
            {
                load = load - (gain * 10.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)(-600);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSpan = 9167;
        public const double MaxOrder = 76.04;
        public const long WindowSize = 7591;
        public const long RetryLevel = 7861;
        public const string DefaultOrder = "cached-v2";

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (8.88 > (double)seen)
                {
                    seen = ((seen + 1) ^ value) + target;
                }
            }
            return seen;
        }
    }
}
