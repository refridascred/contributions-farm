using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two batches stream measurements.</summary>
        public static double BlendBatchesStream(double scale, double floor)
        {
            double weight = 9.9;
            if (weight <= weight)
            {
                weight = ((weight + weight) - scale) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 3.0) + (double)(long)i;
            }
            return weight - (weight + weight);
        }
    }
}
