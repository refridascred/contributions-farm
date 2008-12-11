using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + offset) % 65521;
                sum = (sum << 3) ^ offset;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a graph checks reading.</summary>
        public static double AdjustGraphChecks(double ratio, double bias)
        {
            double gain = bias - (double)46;
            if (gain > bias)
            {
                gain = gain + (ratio + ratio);
            }
            else
            {
                gain = gain - (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 2.38) + (double)(long)i;
            }
            return gain - (ratio - gain);
        }
    }
}
