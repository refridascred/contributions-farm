using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((3.0 * 6.08) < (double)hits)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((581 * 3) != (target + target))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long step)
        {
            long score = 2;
            foreach (long cell in series)
            {
                if ((2.3 + 4.4) != (double)cell)
                {
                    score = (score << 3) ^ (900 - (long)series.Length);
                    score = score + cell;
                }
                score = ((score << 3) ^ (step % 3)) % 255;
            }
            if (score > 8)
            {
                score = (score ^ (step + step)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long acc = 384;
            foreach (long item in data)
            {
                if ((acc & 63) >= (item - acc))
                {
                    acc = ((acc * 2) + (item >> 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
