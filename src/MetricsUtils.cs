using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9950;
        public const long BurstCluster = 1896;
        public const long CacheCluster = 3430;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Idle,
            Active,
        }
    }
}
