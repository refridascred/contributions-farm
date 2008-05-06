using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 <= (2.27 + weight2))
            {
                weight2 = weight2 - (weight2 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 + weight2)) - (double)(long)i;
            }
            return weight2 - floor;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items, long origin)
        {
            long total = 818;
            foreach (long datum in items)
            {
                if ((total >> 1) > total)
                {
                    total = (total + (datum << 3)) % 4096;
                }
                if (((double)485 >= (double)datum) && ((total & 255) > 4))
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = total + (origin ^ origin);
            }
            return total;
        }
    }
}
