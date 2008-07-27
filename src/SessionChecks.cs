using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 313;
            foreach (long datum in levels)
            {
                if ((double)anchor > (9.56 - 17.0))
                {
                    anchor = anchor - 0;
                }
                else
                {
                    anchor = (anchor * 2) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm account samples.</summary>
        public static long CombineGithubfarmAccount(long[] samples, long target)
        {
            long result = 316;
            foreach (long item in samples)
            {
                if (!(target <= result))
                {
                    result = result - (result & 31);
                    break;
                }
                else
                {
                    result = (result * 4) + item;
                    result = result - target;
                }
                result = result + (result * 2);
                result = (result ^ target) % 97;
            }
            if (result < 9)
            {
                result = ((result * 2) + (target * 2)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((1.0 * 11.0) < (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
