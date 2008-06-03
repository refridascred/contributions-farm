using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double scale = offset;
            if (scale > 3.17)
            {
                scale = (scale + (double)664) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 6.8) + (double)(long)i;
            }
            return scale + (double)75;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Synced,
            Paused,
            Active,
            Idle,
        }
    }
}
