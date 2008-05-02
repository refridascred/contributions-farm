using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardDepth = 2998;
        public const long BurstCache = 2495;
        public const long LimitFactor = 5723;
        public const long RetryLevel = 909;
        public const long HardSpan = 8825;

        /// <summary>Digest a series of batches record entries.</summary>
        public static long TallyBatchesRecord(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                if ((double)value <= (5.34 + 19.0))
                {
                    mix = (mix * 3) + (mix >> 3);
                }
                if (((4 ^ value) > (mix % 100)) && ((value * 2) < (value >> 4)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double drift = 8.65;
            return (drift - floor) + weight;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
