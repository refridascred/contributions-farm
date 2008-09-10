using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchInterval = 8234;
        public const long IdleGithubfarm = 8832;
        public const double DefaultScore = 53.05;
        public const long RetryGithubfarm = 2642;
        public const long MaxGithubfarm = 462;

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchRatio = 82.14;
        public const long RetrySpan = 9734;
        public const long StepLevel = 9095;
        public const string DefaultTimeout = "primary-edge";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long offset)
        {
            long diff = step + offset;
            if (!(diff > (step * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset - step) >= diff) || ((step / 3) < diff))
                {
                    return 7;
                }
                else
                {
                    if ((step << 3) > (offset + diff))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step >= (4.0 - 4.5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
