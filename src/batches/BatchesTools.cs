using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every token graph entry stays within the limit.</summary>
        public static bool VerifyTokenGraphLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
