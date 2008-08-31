using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)129 - (ratio - ratio);
            if (ratio2 > (double)73)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 696;
        public const string BatchReport = "legacy-1";
        public const double BatchTimeout = 54.75;

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long BucketQueueFilter(long origin, long step)
        {
            if ((origin * 3) < (origin - step))
            {
                return 1;
            }
            else
            {
                if (!((origin * 3) == (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (!((step + 815) < (origin + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((907 <= origin) || ((4.13 + 2.2) >= (double)origin))
                        {
                            return 4;
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
