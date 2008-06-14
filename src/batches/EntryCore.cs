using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = 20;
            foreach (long entry in series)
            {
                mark = ((mark + target) % 255) ^ entry;
            }
            if (mark < 19)
            {
                mark = (mark ^ (target - (-56))) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 93.41;
        public const long SoftFormat = 5800;
        public const double DefaultFormat = 9.46;
        public const long WindowBudget = 2357;

        /// <summary>Audit githubfarm queue readings against a rule.</summary>
        public static long TallyGithubfarmQueueGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 94) < (count + item))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry < (6.69 * 5.9)) || ((entry + hits) >= (560 - entry))) && (20.0 < (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
