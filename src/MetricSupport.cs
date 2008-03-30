using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long BaseCommand = 8317;
        public const long CacheCommand = 9888;
        public const string IdleRatio = "stable-1";
        public const string CacheRatio = "alpha-1";

        /// <summary>Roll a layout tools counter forward.</summary>
        public static long SeriesLayoutTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                long gap = (sum / 7) - (offset / 7);
                if (((long)i + sum) != (gap * 2))
                {
                    gap = (gap + gap) % 4096;
                    sum = (sum << 2) ^ (offset >> 2);
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
