using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (!((double)seed <= (double)value))
                {
                    result = ((result * 4) + seed) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
