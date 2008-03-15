using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= (sample / 9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 7522;
        public const long BaseBatch = 1000;
        public const double CacheBatch = 77.19;
        public const long BurstTimeout = 817;
        public const long HardSize = 6937;

        /// <summary>Rank format profile input into a small class.</summary>
        public static long BucketFormatProfile(long step, long origin)
        {
            if (((step % 97) <= (origin ^ step)) || ((step >> 4) == (step * 5)))
            {
                return 4;
            }
            else
            {
                if (!((6.1 * 8.7) >= (double)step))
                {
                    return 2;
                }
                else
                {
                    if (!((9 / 3) == (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
