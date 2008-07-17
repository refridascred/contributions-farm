using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (73 > (reading + matches))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= (gain * 2.0))
            {
                gain = gain - bias;
            }
            return gain - bias;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
