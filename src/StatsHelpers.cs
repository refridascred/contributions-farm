using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the filter entry series from a seed.</summary>
        public static long DeriveFilterEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long prev = ((long)i2 - step) ^ (step + (long)i);
                    result = result - (prev & 7);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (((origin & 7) <= (12 / 5)) && ((double)seed != (1.95 * 1.91)))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (9.2 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (2.09 * 11.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepLevel = 469;
        public const double IdleSize = 70.62;
        public const long MinWidth = 3376;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
