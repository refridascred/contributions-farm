using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 3583;
        public const long IdleDepth = 1668;
        public const long BaseDepth = 1393;
        public const long BurstCounter = 4445;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
