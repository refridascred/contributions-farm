using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "primary-edge";
        public const string BatchStats = "legacy-1";
        public const string LimitStats = "local";
        public const long SoftInterval = 4453;
        public const double WindowTimeout = 55.6;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= (tally / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Draft,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long limit)
        {
            if (!((limit / 4) < bound))
            {
                return 7;
            }
            else
            {
                if ((5.5 / 7.0) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound >> 4) < (limit / 3)) && ((16.0 - 10.0) != (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound < 1.75)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
