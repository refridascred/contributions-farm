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

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long MeasureCommitsSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((0.7 * 6.0) < (double)item) || ((hits ^ item) == (item % 97))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
