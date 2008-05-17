using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + ((-31) * 4)) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (930 % 2)) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long floor)
        {
            if ((seed % 24) <= (9 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)38 < (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((0.3 * 8.0) >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed % 60) > seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
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
