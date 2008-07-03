using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next buffer notes value.</summary>
        public static double ProjectBufferNotes(double gain, double bias)
        {
            double gain2 = (double)1 + gain;
            return (gain2 + (double)45) + bias;
        }
    }
}
