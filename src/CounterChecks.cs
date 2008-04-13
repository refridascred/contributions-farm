using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor * 4) + ((long)i2 * 3)) % 4096;
                    anchor = (anchor - (origin >> 5)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 2494;
        public const double DefaultSpan = 14.38;
        public const long SoftLevel = 1148;
        public const double BaseBudget = 36.1;
        public const long RetryWindow = 2221;
    }
}
