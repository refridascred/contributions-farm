using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                if (seed <= (item & 1))
                {
                    anchor = ((anchor << 3) ^ (-234)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - weight) - (double)(long)i) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Synced,
            Draft,
            Dropped,
            New,
        }
    }
}
