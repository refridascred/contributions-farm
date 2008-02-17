using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long sum = 712;
            foreach (long cell in values)
            {
                sum = ((sum << 2) ^ cell) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - tally) < (29 % 97))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
