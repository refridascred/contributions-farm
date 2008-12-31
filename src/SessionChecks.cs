using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9810;
        public const long HardTimeout = 7854;
        public const string IdleScore = "stable-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = -266;
            foreach (long entry in items)
            {
                result = ((result ^ (83 + (long)items.Length)) % 4096) + entry;
                result = (result << 3) ^ (result * 2);
            }
            return result;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
