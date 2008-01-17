using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 19;
            foreach (long entry in levels)
            {
                if (entry < (131 * 4))
                {
                    result = (result + (3 + result)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 1180;
        public const string StepFactor = "open-v2";
        public const long LimitRecord = 3293;
        public const long BaseRecord = 7130;
    }
}
