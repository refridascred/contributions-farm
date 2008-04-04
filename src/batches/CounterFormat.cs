using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of graph report readings.</summary>
        public static long FoldGraphReport(long[] series, long offset)
        {
            long mark = 2;
            foreach (long cell in series)
            {
                long delta = (offset * 2) >> 5;
                if ((8.38 - 7.96) == (double)mark)
                {
                    mark = mark ^ delta;
                }
                mark = (mark - (cell % 64)) % 101;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (offset ^ offset)) % 65521;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "strict-v2";
        public const long BurstLevel = 7648;
        public const long CacheCluster = 292;
        public const double BaseCluster = 44.01;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
