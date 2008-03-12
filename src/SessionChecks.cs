using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a metric contributi pair into a bucket.</summary>
        public static long GradeMetricContributi(long step, long target)
        {
            if ((target - step) != (step + 45))
            {
                return 6;
            }
            else
            {
                if ((3.6 + 4.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (((double)step <= (5.0 / 9.0)) || ((step + step) < 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step > (6.66 + 6.64)) || ((double)target < (1.2 + 8.4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
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
