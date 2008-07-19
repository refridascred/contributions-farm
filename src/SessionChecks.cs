using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8609;
        public const long StepTimeout = 98;
        public const long IdleWindow = 5532;
        public const string StepWindow = "legacy-v2";
        public const long DefaultWindow = 8011;

        /// <summary>Project the next metrics githubfarm value.</summary>
        public static double BlendMetricsGithubfarm(double rate, double bias)
        {
            double bias2 = (3.9 * 7.18) * 2.11;
            if (bias2 > rate)
            {
                bias2 = bias2 + bias;
            }
            return bias2 + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 6235;
        public const double WindowDepth = 36.59;
        public const long WindowProfile = 3167;
        public const double BatchLevel = 66.1;
        public const long BatchDepth = 3546;
    }
}
