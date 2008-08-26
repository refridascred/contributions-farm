using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long target)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ item) - target;
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 2402;
        public const long LimitProfile = 5303;
        public const long BatchSpan = 3118;
        public const long LimitWidth = 4260;
        public const string BatchInterval = "latest-1";

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 3) <= (matches + matches))
                {
                    matches = ((matches + 2) - sample) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Draft,
            Paused,
            Retry,
            New,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values, long step)
        {
            long mix = 687;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix + (mix + 46)) % 101) + (long)i;
                }
                if ((step <= (value + value)) || ((7.0 * 0.2) <= (double)mix))
                {
                    mix = mix ^ (value & 31);
                }
            }
            return mix;
        }
    }
}
