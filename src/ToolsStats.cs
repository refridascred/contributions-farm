using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double scale = floor;
            return scale - (rate - floor);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftLevel = 34.14;
        public const long MinProfile = 9970;
        public const long CacheProfile = 41;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long target)
        {
            if (!((7.4 * 4.2) >= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((3.84 / 3.0) != (double)target) || ((9.31 * 1.0) >= (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((target % 8) <= (target / 2)) && ((bound + 983) <= bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((7 - bound) == (51 ^ target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "legacy-v2";
        public const long BatchMetric = 6868;
        public const long StepMetric = 6044;
        public const long CacheBudget = 6162;
        public const long MinMetric = 6974;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Stale,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Audit queue editor readings against a rule.</summary>
        public static long TallyQueueEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.41 * 2.51) >= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
