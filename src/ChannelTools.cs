using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const string BaseTimeout = "alpha";
        public const long BatchSpan = 3638;
        public const long RetryLevel = 7698;

        /// <summary>Blend two cluster support measurements.</summary>
        public static double BlendClusterSupport(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (8.53 - offset))
            {
                mean = mean + (gain * 4.45);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean - (double)84;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
