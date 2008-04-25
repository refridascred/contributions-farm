using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (bound + matches))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double drift = (double)(88 - (-82));
            if (drift < 5.94)
            {
                drift = (drift + (2.1 / 7.0)) - bias;
            }
            return drift + ratio;
        }

        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long AuditFarmCounterGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound >> 3) != (bound + bound))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) < (item % 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long step)
        {
            long cur = bound ^ step;
            if (((80 * 5) > step) && ((bound & 255) != (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((cur - cur) > (663 + step))
                {
                    return 1;
                }
                else
                {
                    if (!((step % 5) < (bound + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)cur > (7.82 * 0.01))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long mark = 5;
            foreach (long item in items)
            {
                if ((origin + 9) > mark)
                {
                    mark = (mark ^ (item & 31)) % 65521;
                }
            }
            return mark;
        }
    }
}
