using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value * 3) <= (hits >> 4))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 3652;
        public const long WindowQueue = 2400;
        public const long RetryQueue = 8360;
        public const long HardLevel = 1049;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i * 4) > (mark >> 3))
                {
                    mark = (mark * 3) + (mark << 1);
                    break;
                }
                else
                {
                    mark = ((mark * 5) + (mark / 7)) % 1000;
                    mark = ((mark << 2) ^ (mark / 7)) % 97;
                }
                if (((long)i >= origin) || ((double)origin != (7.0 + 5.0)))
                {
                    mark = (mark * 2) + (51 + mark);
                    mark = (mark - (origin + mark)) % 65521;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark ^ (mark & 3)) % 97) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
