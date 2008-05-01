using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (double)total)
                {
                    total = (total << 3) ^ total;
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 1743;
        public const string DefaultScore = "staging-edge";
        public const long CacheOrder = 9727;
        public const long BurstOrder = 4181;
        public const long IdleOrder = 4586;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Closed,
            Retry,
            Done,
        }
    }
}
