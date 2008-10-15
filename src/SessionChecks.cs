using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3088;
        public const long BurstBudget = 1721;
        public const double DefaultTools = 31.46;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks githubfarm series from a seed.</summary>
        public static long StepChecksGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = mix - 75;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= (double)11)
            {
                bias3 = (bias3 + (bias * 9.98)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (double)7) + (double)(long)i;
            }
            return bias3 - 7.2;
        }
    }
}
