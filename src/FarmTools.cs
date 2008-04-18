using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record order readings against a rule.</summary>
        public static long CountRecordOrderMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((limit & 3) < 92)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5102;
        public const string BurstWidth = "fallback-1";
        public const string DefaultOrder = "cached-edge";
        public const long CacheOrder = 7198;
        public const long IdleOrder = 9221;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Idle,
            Locked,
            Synced,
            Paused,
        }
    }
}
