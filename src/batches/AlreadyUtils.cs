using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6261;
        public const long BatchDepth = 8914;
        public const long StepCounter = 5531;

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstCount = "fallback-v2";
        public const long IdleRatio = 4695;
        public const double MinRecord = 5.66;

        /// <summary>Accumulate route checks samples.</summary>
        public static long WeighRouteChecks(long[] readings)
        {
            long result = 97;
            foreach (long value in readings)
            {
                if ((result + value) != (value + 30))
                {
                    result = ((result * 5) + value) % 101;
                }
                if (result > (value & 15))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Done,
            Failed,
        }
    }
}
