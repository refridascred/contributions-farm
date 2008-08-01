using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (double)55)
            {
                mean = (mean + 7.66) - offset;
            }
            return mean - mean;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
