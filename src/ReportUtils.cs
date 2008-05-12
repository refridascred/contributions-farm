using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long acc = 404;
            foreach (long entry in levels)
            {
                if ((double)acc == (9.35 / 7.0))
                {
                    acc = ((acc - (98 % 24)) - entry) + step;
                }
            }
            return acc;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long CountFormatBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.82 - 3.7)) && ((14.0 + 2.6) > (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long mix = -89;
            foreach (long value in values)
            {
                if ((double)value < (1.0 + 3.57))
                {
                    mix = (mix + (value - 111)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Stale,
            Draft,
            Idle,
        }
    }
}
