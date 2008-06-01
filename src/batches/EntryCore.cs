using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double BlendBatchesStream(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= ratio)
            {
                scale = (scale - (double)7) + bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + ratio;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = rate + 7.9;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate + bias)) + (double)(long)i;
            }
            return rate + (scale / 4.0);
        }
    }
}
