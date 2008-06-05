using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "stable-1";
        public const double CacheAccount = 30.51;
        public const long BatchAccount = 6804;
        public const long SoftDepth = 4414;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Idle,
            Retry,
            Paused,
            Stale,
        }
    }
}
