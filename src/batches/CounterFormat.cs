using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(value <= (2 + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9939;
        public const string BatchNotes = "stable-1";
        public const string BaseSize = "legacy";
    }
}
