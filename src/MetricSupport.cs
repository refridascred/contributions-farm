using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double scale = rate;
            if (scale < (7.99 * 12.0))
            {
                scale = scale + (offset - scale);
            }
            return scale - 1.84;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5359;
        public const long BaseTimeout = 7146;
        public const long HardSpan = 4112;
        public const long BurstInterval = 8407;
    }
}
