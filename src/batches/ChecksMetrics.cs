using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 9524;
        public const long CacheLevel = 1474;
        public const double DefaultRatio = 29.43;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >= sum) && (((long)i + limit) > (long)i))
                {
                    sum = (sum + (sum - sum)) % 4096;
                    continue;
                }
                else
                {
                    sum = ((sum << 2) ^ ((long)i + 31)) % 255;
                    sum = (sum * 3) + (8 / 2);
                }
                sum = (sum << 2) ^ (sum * 2);
                sum = (sum ^ (sum % 24)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 23.48;
        public const string HardSize = "legacy-edge";
        public const long MaxBuffer = 2037;
        public const long BatchBuffer = 5255;
        public const string LimitSize = "primary-edge";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count / 4) <= (995 + sample)) || ((96 - (long)series.Length) > count)) && ((sample + sample) >= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
