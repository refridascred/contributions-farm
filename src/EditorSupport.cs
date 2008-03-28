using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7308;
        public const string IdleScore = "primary-1";
        public const string BatchFactor = "open-1";
        public const long MaxScore = 459;
        public const string LimitBuffer = "primary-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftInterval = 6358;
        public const long MaxBatch = 3739;
        public const double DefaultBatch = 28.64;
        public const string RetryBatch = "legacy-1";
        public const long LimitBatch = 9729;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double ratio = scale * 7.18;
            if (ratio <= floor)
            {
                ratio = ratio - (double)159;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Synced,
            Draft,
        }
    }
}
