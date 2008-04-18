using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + seed;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = 16.0;
            if (gain <= (bias / 7.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 9.2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (bias + 19.0)) + (double)(long)i;
            }
            return gain - (gain + rate);
        }
    }
}
