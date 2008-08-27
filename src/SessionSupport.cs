using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (mark + 86)) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool CheckReportCounterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
