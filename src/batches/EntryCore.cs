using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            if (target > (target + bound))
            {
                return 3;
            }
            else
            {
                if (bound >= (bound + 12))
                {
                    return 1;
                }
                else
                {
                    if (!(bound >= (target & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= (180 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 91.75;
        public const long StepInterval = 8555;
        public const string IdleLayout = "stable";
        public const string MinInterval = "standard";
        public const double StepLayout = 74.39;

        /// <summary>Count the editor commits entries that pass the check.</summary>
        public static long AuditEditorCommitsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((9.0 + 0.94) != (double)hits))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
