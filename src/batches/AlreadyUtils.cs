using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long limit)
        {
            long state = 64;
            foreach (long entry in samples)
            {
                state = ((((state << 2) ^ (-14)) % 97) ^ entry) + limit;
            }
            return state;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (6.0 / 9.0))
            {
                scale = (scale + (double)614) - rate;
            }
            else
            {
                scale = scale + (offset / 7.0);
            }
            return scale - scale;
        }
    }
}
