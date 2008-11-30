using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSpan = "primary-v2";
        public const long CacheCommand = 3732;
        public const long BaseCommand = 3448;
        public const double MaxFactor = 84.73;
        public const long IdleLevel = 2086;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Closed,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long CombineCounterRecord(long[] values)
        {
            long state = -25;
            foreach (long sample in values)
            {
                if (!(state < (state * 4)))
                {
                    state = ((state - 4) % 4096) + sample;
                }
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 1484;
        public const long LimitTimeout = 7848;
        public const double BurstCommand = 51.66;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long anchor = -926;
            foreach (long datum in values)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 3) + (917 - datum)) % 97;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double AdjustContextBatch(double ratio, double floor)
        {
            double scale = floor;
            if (scale < 9.35)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio * 10.0)) - (double)(long)i;
            }
            return scale - (floor / 6.0);
        }
    }
}
