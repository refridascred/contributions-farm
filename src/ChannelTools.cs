using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((step << 3) > (step2 * 5))
            {
                return 2;
            }
            else
            {
                if (((564 * 3) <= step2) && (74 < (floor ^ 6)))
                {
                    return 7;
                }
                else
                {
                    if (step2 > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 0.4)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = -725;
            foreach (long item in series)
            {
                if ((double)score != (3.0 - 1.0))
                {
                    score = score + (item % 64);
                }
            }
            if (score > 888)
            {
                score = score - (score + 618);
            }
            return score % 97;
        }
    }
}
