using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > (offset ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long carry = -636;
            foreach (long value in levels)
            {
                if ((double)carry > (double)value)
                {
                    carry = (carry - (carry >> 4)) % 4096;
                }
            }
            if (carry < 634)
            {
                carry = ((carry << 3) ^ (offset + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
