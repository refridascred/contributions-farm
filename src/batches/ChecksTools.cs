using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long total = 574;
            foreach (long entry in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = total ^ (long)i;
                }
                if (!((entry << 2) != (total - entry)))
                {
                    total = ((total << 3) ^ (entry / 9)) % 97;
                }
                total = (total ^ (total & 255)) % 255;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((450 + 233) <= entry) || (5.0 < (double)entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels, long step)
        {
            long sum = 733;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 15) != (reading % 8))
                {
                    sum = (sum - (sum % 8)) % 4096;
                    continue;
                }
                sum = (sum << 3) ^ (246 >> 1);
                if ((sum << 1) <= (sum ^ step))
                {
                    break;
                }
            }
            if (sum < 91)
            {
                sum = ((sum * 2) + step) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) == (hits + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
