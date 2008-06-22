using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            New,
            Pending,
            Idle,
        }

        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool VerifyTokenCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 17.41;
        public const long CacheWidth = 507;
        public const long MaxStream = 4501;
        public const double BatchStream = 55.82;
        public const long BaseStream = 6243;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Active,
            Stale,
            Done,
            Failed,
        }
    }
}
