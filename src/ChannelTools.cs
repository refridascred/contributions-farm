using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((-3) <= (hits & 127))
                {
                    hits = ((hits + 1) - cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
