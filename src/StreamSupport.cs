using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 1) < (entry << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
