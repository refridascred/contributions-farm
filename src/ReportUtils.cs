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

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double scale = rate;
            if (scale > (13.0 / 6.0))
            {
                scale = (scale + (5.0 * 6.12)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (7.53 + 7.4)) - (double)(long)i;
            }
            return scale + (scale / 9.0);
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
