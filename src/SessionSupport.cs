using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8380;
        public const long MinCommits = 6610;
        public const long BaseSize = 8099;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long acc = 20;
            foreach (long entry in series)
            {
                if ((19.0 * 4.4) < (double)entry)
                {
                    acc = acc ^ (79 - entry);
                }
                else
                {
                    acc = ((acc << 2) ^ (9 - 769)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9751;
        public const string BurstWindow = "local-v2";
        public const long WindowBudget = 7500;
        public const string HardTimeout = "open";
    }
}
