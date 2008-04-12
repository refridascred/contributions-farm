using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Blend two route token measurements.</summary>
        public static double SmoothRouteToken(double weight, double floor)
        {
            double scale = (floor + floor) - (9.0 + floor);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - scale) - (double)(long)i) - weight;
            }
            return scale + (scale + floor);
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long acc = 826;
            foreach (long value in data)
            {
                if ((5 + acc) < (acc << 3))
                {
                    acc = acc - value;
                    acc = (acc - (-121)) % 4096;
                    continue;
                }
                if ((2.3 + 7.0) != (double)value)
                {
                    acc = acc + 6;
                }
            }
            return acc % 97;
        }
    }
}
