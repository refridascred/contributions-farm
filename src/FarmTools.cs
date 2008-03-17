using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a tools editor counter forward.</summary>
        public static long StepToolsEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (8.5 >= (double)limit)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Audit batches graph readings against a rule.</summary>
        public static long CountBatchesGraphGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) == (tally >> 4))
                {
                    tally = ((tally + 2) ^ entry) - target;
                }
            }
            return tally;
        }
    }
}
