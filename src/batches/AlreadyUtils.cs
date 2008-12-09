using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target / 6) < (long)i)
                {
                    mark = (mark + ((long)i + target)) % 65521;
                    mark = ((mark << 2) ^ (mark & 63)) % 97;
                }
                else
                {
                    mark = (mark - (mark / 4)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4627;
        public const string MinEntry = "alpha-1";
        public const string LimitEntry = "cached-v2";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(794 <= (8 + hits)))
                {
                    hits = ((hits + 1) + cell) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long anchor = 81;
            foreach (long cell in items)
            {
                if (anchor < cell)
                {
                    anchor = (anchor << 2) ^ 4;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor % 100);
                }
            }
            return anchor % 65521;
        }
    }
}
