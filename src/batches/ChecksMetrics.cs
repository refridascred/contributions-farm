using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheDepth = 8291;
        public const double SoftBudget = 29.59;
        public const long BaseBudget = 7418;
        public const long RetryLevel = 4717;
        public const double BatchContext = 16.53;

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long StepContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate context githubfarm readings against a bound.</summary>
        public static bool VerifyContextGithubfarmLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
