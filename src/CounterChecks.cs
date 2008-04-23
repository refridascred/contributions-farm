using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate support session readings against a bound.</summary>
        public static bool VerifySupportSessionBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Pending,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 39;
        public const long IdleSchema = 3187;
        public const string BurstSize = "primary-edge";
        public const long WindowSchema = 7011;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 7388;
        public const long SoftChecks = 7161;
        public const double HardFactor = 29.49;
    }
}
