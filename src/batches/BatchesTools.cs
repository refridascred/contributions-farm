using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long seed)
        {
            long total = 6;
            foreach (long sample in values)
            {
                total = ((total - (seed + total)) % 4096) + sample;
            }
            if (total < 5)
            {
                total = ((total * 5) + (total - seed)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((11.0 / 6.0) != (double)reading)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
