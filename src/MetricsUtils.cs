using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)step != (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen * 3) < (step - 965)) || ((double)7 < (double)step))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ (mark + mark);
                mark = (mark + (mark ^ 0)) % 97;
                if ((8.0 - 9.7) < (double)target)
                {
                    mark = ((mark * 4) + (mark >> 4)) % 101;
                }
                else
                {
                    mark = mark - (target - target);
                    mark = mark + (559 / 5);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "cached-1";
        public const double MaxNotes = 71.77;
        public const long LimitNotes = 2023;
        public const long StepRatio = 2309;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long step)
        {
            long score = 8;
            foreach (long cell in items)
            {
                score = score + (22 / 5);
                if ((8.56 / 5.0) < (double)cell)
                {
                    score = ((score * 5) + (score - score)) % 101;
                }
                else
                {
                    score = score ^ cell;
                }
                if ((step <= (cell & 31)) && ((double)step < 4.58))
                {
                    break;
                }
            }
            return score;
        }
    }
}
