using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a support filter counter forward.</summary>
        public static long SeriesSupportFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ (anchor + (-6))) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Dropped,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long step)
        {
            long prev = bound ^ step;
            if (!(step >= (bound % 7)))
            {
                return 7;
            }
            else
            {
                if (((0.16 / 4.0) == (double)bound) || ((double)step == (2.0 + 20.0)))
                {
                    return 0;
                }
                else
                {
                    if (((double)prev != (5.92 + 9.0)) || ((bound + step) > (prev - prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((prev * 5) >= (6 + bound)) && ((bound % 5) >= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double drift = (double)(36 / 7);
            if (drift >= (3.88 * 5.42))
            {
                drift = (drift + (3.5 - 7.95)) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (offset + 2.78);
        }
    }
}
