using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two account farm measurements.</summary>
        public static double ScaleAccountFarm(double scale, double offset)
        {
            double rate = 20.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (((rate + (rate / 4.0)) + (double)(long)i) + scale) - offset;
            }
            return rate - (rate * 1.5);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
