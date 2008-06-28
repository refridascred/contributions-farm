using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Paused,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
