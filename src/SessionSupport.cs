using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = (double)(611 ^ 402);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 6.68) + (double)(long)i) + weight;
            }
            return scale - span;
        }
    }
}
