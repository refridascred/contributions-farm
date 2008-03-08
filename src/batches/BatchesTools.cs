using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long mix = 908;
            foreach (long reading in data)
            {
                if (((mix + reading) < (seed ^ 3)) || ((0 - mix) >= 175))
                {
                    mix = (mix << 3) ^ mix;
                }
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((-97) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
