using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of counter layout readings.</summary>
        public static long ScoreCounterLayout(long[] items)
        {
            long carry = 361;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ carry) % 255) - (long)i;
                }
                if (!(carry > value))
                {
                    carry = (carry << 2) ^ (carry - 44);
                }
                if ((6.3 / 3.0) == (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 55.56;
        public const long BaseWidth = 3498;
        public const string IdleInterval = "latest-v2";
        public const double LimitStream = 62.79;
        public const long RetryWidth = 925;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
