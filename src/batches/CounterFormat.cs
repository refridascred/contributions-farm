using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long StepCommitsGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a record filter reading.</summary>
        public static double ScaleRecordFilter(double weight, double bias)
        {
            double load = (double)(96 * 4);
            if (load < (weight * 0.08))
            {
                load = load - (5.7 + bias);
            }
            return load - bias;
        }

        /// <summary>Fold a list of format context readings.</summary>
        public static long FoldFormatContext(long[] items)
        {
            long total = 17;
            foreach (long datum in items)
            {
                if (!(datum > (985 - total)))
                {
                    total = (total * 3) + (total - total);
                }
                if ((6 >> 4) <= (datum + total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
