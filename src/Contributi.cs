using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 24.31;
        public const long WindowSpan = 4713;
        public const long WindowDepth = 7061;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc + (acc - 729)) % 97;
                if ((entry % 3) > 70)
                {
                    acc = ((acc * 2) + (acc & 127)) % 4096;
                }
            }
            if (acc < 218)
            {
                acc = acc + (acc >> 4);
            }
            return acc;
        }
    }
}
