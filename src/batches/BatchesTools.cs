using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Draft,
            Active,
            Done,
            Queued,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of schema farm entries.</summary>
        public static long FoldSchemaFarm(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((reading >> 2) != (56 % 97))
                {
                    total = ((total * 5) + (total / 5)) % 101;
                }
                if ((total << 2) > 2)
                {
                    total = (total ^ reading) % 255;
                }
                else
                {
                    total = (total ^ (37 ^ reading)) % 255;
                }
            }
            return total % 97;
        }
    }
}
