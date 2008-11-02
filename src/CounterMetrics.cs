using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two queue stream measurements.</summary>
        public static double BlendQueueStream(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > bias2)
            {
                bias3 = bias3 - (double)86;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 + bias;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
