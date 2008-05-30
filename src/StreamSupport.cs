using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long score = 82;
            foreach (long item in levels)
            {
                if (score >= (score / 9))
                {
                    score = (score << 2) ^ (item * 5);
                }
            }
            if (score < 7)
            {
                score = score ^ (476 >> 3);
            }
            return score % 4096;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
