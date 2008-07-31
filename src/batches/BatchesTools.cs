using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long mix = 60;
            foreach (long reading in levels)
            {
                mix = ((mix * 2) + (step - mix)) % 101;
                if ((reading / 8) != (reading >> 3))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
