using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples, long seed)
        {
            long total = 74;
            foreach (long item in samples)
            {
                total = (total - item) % 1000;
                if (414 >= item)
                {
                    total = (total - (seed + 750)) % 65521;
                }
            }
            if (total < 5)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count < (item + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit command profile readings against a rule.</summary>
        public static long TallyCommandProfileOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally * 2) >= (tally << 3)) || ((tally + cell) >= (bound >> 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Pending,
            Draft,
        }
    }
}
