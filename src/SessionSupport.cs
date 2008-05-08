using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 3) < (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstWidth = "primary-v2";
        public const string IdleStream = "latest";
        public const long BurstCount = 2610;
        public const long CacheSpan = 2872;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Ready,
            Failed,
            Idle,
        }
    }
}
