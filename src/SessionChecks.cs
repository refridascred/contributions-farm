using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long origin)
        {
            long total = 390;
            foreach (long datum in values)
            {
                total = ((((total << 3) ^ total) % 1000) + datum) - origin;
            }
            return total % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha";
        public const string BatchFarm = "latest-edge";
        public const long DefaultRatio = 5000;
        public const long RetrySpan = 4437;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((seen % 16) >= (entry + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
