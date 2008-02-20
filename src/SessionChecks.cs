using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "strict-1";
        public const long SoftSpan = 3721;
        public const double StepReport = 83.44;
        public const long MaxLevel = 9469;
        public const double SoftReport = 59.44;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = total - (total - bound);
                total = (total * 3) + ((long)i / 8);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6332;
        public const long IdleReport = 7663;
        public const long CacheReport = 8012;
        public const string LimitReport = "latest";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
