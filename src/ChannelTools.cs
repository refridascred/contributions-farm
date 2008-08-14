using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 87.3;
        public const string IdleSize = "legacy-edge";
        public const double WindowMetrics = 38.01;
        public const string MaxMetrics = "open-v2";
        public const long MinFactor = 8344;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = (mix << 3) ^ (mix - value);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - (-429)) != (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
