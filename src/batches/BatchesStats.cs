using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Ready,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 3566;
        public const string BurstBuffer = "latest-1";
        public const long HardBuffer = 3710;
        public const string WindowBuffer = "strict";
        public const double BurstScore = 91.44;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total - (long)i) % 101) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const string WindowCache = "local-edge";
        public const double LimitTimeout = 96.69;
    }
}
