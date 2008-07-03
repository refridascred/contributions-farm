using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a window already sample.</summary>
        public static long LookupWindowAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer notes value.</summary>
        public static double ProjectBufferNotes(double gain, double bias)
        {
            double gain2 = (double)1 + gain;
            return (gain2 + (double)45) + bias;
        }
    }
}
