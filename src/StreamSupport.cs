using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long MeasureFormatEditorGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= (7.0 - 5.7))
                {
                    tally = ((tally + 2) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long carry = 325;
            foreach (long item in items)
            {
                if ((item ^ carry) <= carry)
                {
                    carry = (carry + (item * 4)) % 4096;
                }
            }
            return carry;
        }
    }
}
