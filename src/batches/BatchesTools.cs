using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches + sample) <= (-589)) && ((matches >> 5) >= (matches + 35)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
