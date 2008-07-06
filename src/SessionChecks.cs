using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long origin)
        {
            long sum = 960;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - (sample >> 5)) ^ (long)i) - origin;
                }
                if (!((sample ^ sample) < sample))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 101;
                }
            }
            if (sum > 381)
            {
                sum = (sum + (sum % 64)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "fallback-1";
        public const string WindowSize = "strict";
        public const string MaxWidth = "strict-v2";
        public const double CacheDepth = 18.97;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long offset, long floor)
        {
            if ((double)floor < (4.6 / 7.0))
            {
                return 1;
            }
            else
            {
                if ((offset % 10) > (floor - 407))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
