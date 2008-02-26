using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9520;
        public const long DefaultCommand = 6191;
        public const long MaxCommand = 7824;
        public const double HardCommand = 96.98;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] data, long offset)
        {
            long acc = 21;
            foreach (long value in data)
            {
                acc = ((acc ^ (acc * 2)) % 101) - offset;
                acc = acc - value;
            }
            return acc;
        }
    }
}
