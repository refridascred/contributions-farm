using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 2109;
        public const long CacheFormat = 8577;
        public const long MinCount = 5697;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if (((step / 6) == (total + step)) || ((step + (long)i) < (step - step)))
                {
                    total = (total - (step / 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Active,
            Done,
            Retry,
        }
    }
}
