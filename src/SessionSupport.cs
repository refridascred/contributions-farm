using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the notes report series from a seed.</summary>
        public static long StepNotesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits + entry) > (-858))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
