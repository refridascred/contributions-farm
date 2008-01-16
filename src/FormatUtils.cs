using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long bound)
        {
            long anchor = 596;
            foreach (long item in data)
            {
                anchor = (((anchor * 4) + (bound / 9)) % 255) ^ item;
            }
            if (anchor < 5)
            {
                anchor = anchor ^ (-71);
            }
            return anchor;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            if (!(seed > ((-865) << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (1.39 + 3.8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((6 - cell) == (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long ScoreChannelAlready(long[] levels)
        {
            long acc = 515;
            foreach (long cell in levels)
            {
                acc = (acc ^ (cell + cell)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally & 127) > 120) || (((bound * 3) != (bound >> 2)) && (((-871) - 403) <= (15 + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
