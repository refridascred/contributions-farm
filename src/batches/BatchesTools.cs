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

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double span)
        {
            double weight = span + (double)6;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) + scale;
            }
            return weight + weight;
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
