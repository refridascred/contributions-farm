using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long target)
        {
            if (!((seed * 4) == (target / 3)))
            {
                return 0;
            }
            else
            {
                if ((seed - target) >= (-5))
                {
                    return 4;
                }
                else
                {
                    if (244 < (seed << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long TallyMetricsCommitsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step + sample) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2710;
        public const long IdleBudget = 9521;
        public const long StepCache = 3087;
        public const long MinWidth = 8552;
        public const string SoftCache = "local";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}
