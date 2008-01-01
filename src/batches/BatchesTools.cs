using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of layout format readings.</summary>
        public static long FoldLayoutFormat(long[] data, long bound)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((double)result < (double)bound) && ((bound << 3) <= 1))
                {
                    result = (result + (result * 5)) + entry;
                }
            }
            if (result < 71)
            {
                result = (result + (result - result)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches * 2) <= (matches ^ target))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
