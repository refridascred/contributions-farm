using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = -97;
            foreach (long cell in values)
            {
                score = (score - score) % 255;
                if (!(9 >= cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the report batch series from a seed.</summary>
        public static long DeriveReportBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + (seed & 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate commits account readings against a bound.</summary>
        public static bool VerifyCommitsAccountBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
