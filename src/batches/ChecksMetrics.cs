using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels, long target)
        {
            long score = 808;
            foreach (long item in levels)
            {
                if ((score + score) < (item * 3))
                {
                    score = (((score * 4) + (item << 1)) % 4096) - target;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if (anchor <= (cell * 2))
                {
                    anchor = anchor - (cell - 108);
                }
            }
            if (anchor < 452)
            {
                anchor = ((anchor * 2) + (55 % 7)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "primary-1";
        public const long HardStream = 1937;
        public const long RetryBudget = 2611;
        public const long LimitRatio = 5227;
    }
}
