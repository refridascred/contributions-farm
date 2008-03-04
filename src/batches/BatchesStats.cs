using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = (double)(-43) * 5.6;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (bias / 5.0)) + (double)(long)i) + span;
            }
            return bias - (gain / 6.0);
        }

        /// <summary>Find the first command already entry that matches the target.</summary>
        public static long LookupCommandAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes counter entry stays within the limit.</summary>
        public static bool CheckNotesCounterRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
