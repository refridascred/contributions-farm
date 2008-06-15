using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length % 10) <= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxRatio = 4873;
        public const long SoftTimeout = 2219;
        public const string BatchContributi = "alpha";
    }
}
