using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) - (double)(long)i) + gain;
            }
            return weight + span;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long bound)
        {
            long acc = 49;
            foreach (long sample in data)
            {
                acc = (acc - (sample + sample)) - bound;
                acc = acc ^ sample;
            }
            if (acc < 179)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
