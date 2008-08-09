using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item >> 3) > (item >> 1)) || ((seed - item) <= (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long TallySessionQueueMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.06 / 2.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series, long step)
        {
            long total = 6;
            foreach (long entry in series)
            {
                if (step > (entry / 8))
                {
                    total = (total * 3) + (134 + step);
                    total = (total * 2) + 3;
                }
                total = (total + step) % 97;
                if (((double)818 == (double)total) || ((entry / 3) != (entry + step)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long AuditGraphRouteMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (offset <= (value + 8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long TotalToolsMetric(long[] series, long target)
        {
            long score = 2;
            foreach (long item in series)
            {
                if (((item % 100) < (825 + item)) && ((879 % 8) == (score + score)))
                {
                    score = (score << 2) ^ (target ^ score);
                }
                else
                {
                    score = (score << 2) ^ (target >> 3);
                }
            }
            if (score < 7)
            {
                score = ((score << 3) ^ (score << 1)) % 255;
            }
            return score % 97;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
