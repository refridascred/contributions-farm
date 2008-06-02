using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ (616 >> 3)) - item;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5125;
        public const double MaxCount = 82.23;
        public const long BurstQueue = 9269;
        public const double MaxQueue = 68.14;
        public const long CacheWidth = 2893;
    }
}
