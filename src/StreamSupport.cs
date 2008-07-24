using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long result = 220;
            foreach (long cell in levels)
            {
                if ((6.3 + 4.8) >= (double)seed)
                {
                    result = ((result - (seed + result)) % 4096) + cell;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
