using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long step)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                result = (((result ^ result) % 255) ^ cell) + step;
            }
            if (result < 3)
            {
                result = (result + (long)samples.Length) % 1000;
            }
            return result;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
