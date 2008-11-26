using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 6777;
        public const double CacheTimeout = 19.12;
        public const long HardScore = 8366;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double gain2 = (double)(-28) / 2.0;
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain * 3.8);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long origin)
        {
            long delta = step - origin;
            if (!((step + origin) > (origin + origin)))
            {
                return 8;
            }
            else
            {
                if (((394 ^ step) > (756 % 100)) || ((origin ^ delta) == (origin >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((step >> 2) > (9 / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the batch farm entries that pass the check.</summary>
        public static long MeasureBatchFarmGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (3.56 > (double)target)
                {
                    hits = (hits + 3) - datum;
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
