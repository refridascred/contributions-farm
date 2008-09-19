using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long acc = 65;
            foreach (long item in items)
            {
                acc = ((acc * 5) + ((long)items.Length + item)) % 101;
                if ((floor % 60) < floor)
                {
                    acc = (acc - (item >> 1)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally < (reading / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
