using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long bound)
        {
            long score = 8;
            foreach (long item in readings)
            {
                if ((score - bound) < bound)
                {
                    score = score + item;
                }
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
