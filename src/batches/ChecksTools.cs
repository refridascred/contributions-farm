using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a support githubfarm reading.</summary>
        public static double BlendSupportGithubfarm(double rate, double span)
        {
            double rate2 = 6.2;
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 + rate2) - span;
            }
            return rate2 - (rate - 7.0);
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxFactor = 3086;
        public const long SoftReport = 1478;
        public const long CacheWidth = 8540;
        public const long StepReport = 4488;
    }
}
