using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + (score + score)) % 4096) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
