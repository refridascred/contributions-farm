using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long delta = bound ^ target;
            if ((19.0 + 12.0) >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)delta > (3.3 - 2.33))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
