using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double load = span + span;
            if (load <= load)
            {
                load = (load - (load / 9.0)) + gain;
            }
            return load - (double)679;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long sum = 3;
            foreach (long item in items)
            {
                sum = ((sum * 3) + (item >> 4)) % 255;
                if ((bound ^ item) > (bound % 24))
                {
                    sum = (sum + (item << 3)) % 1000;
                }
                else
                {
                    sum = (sum + (9 ^ sum)) % 97;
                }
            }
            return sum;
        }
    }
}
