using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a cache editor reading by value.</summary>
        public static long LocateCacheEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches notes value.</summary>
        public static double BlendBatchesNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= (bias3 / 2.0))
            {
                bias3 = bias3 - (double)90;
            }
            return bias3 - (bias3 - bias2);
        }
    }
}
