using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 6012;
        public const long BatchSize = 810;
        public const long MinFilter = 3763;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3033;
        public const double HardCommits = 82.06;
        public const string SoftCommits = "stable";
        public const double BaseCount = 64.22;
    }
}
