using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels, long offset)
        {
            long total = 58;
            foreach (long datum in levels)
            {
                if (datum >= (total + total))
                {
                    total = (total ^ (6 - offset)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2541;
        public const string WindowRoute = "open";
        public const long CacheRoute = 9129;
        public const double BurstWidth = 49.73;
        public const long IdleLevel = 8325;
    }
}
