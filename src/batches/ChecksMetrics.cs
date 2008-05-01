using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up commits notes samples.</summary>
        public static long CompareCommitsNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long seed, long seed2)
        {
            if ((seed + 6) == (4 + seed2))
            {
                return 2;
            }
            else
            {
                if (((seed & 255) > (6 & 255)) || ((seed2 / 9) < seed2))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 == (5.1 * 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed2 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
