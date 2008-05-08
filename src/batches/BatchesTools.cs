using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double weight2 = (double)(54 / 5);
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 + (bias + 6.75)) + (double)(long)i) - weight;
            }
            return weight2 + (double)91;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
