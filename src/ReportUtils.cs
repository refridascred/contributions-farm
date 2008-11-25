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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry > (count / 4))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Project the next stream payload value.</summary>
        public static double AdjustStreamPayload(double weight, double offset)
        {
            double mean = weight - (offset - offset);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean + 8.9)) + (double)(long)i;
            }
            return mean - (offset / 5.0);
        }
    }
}
