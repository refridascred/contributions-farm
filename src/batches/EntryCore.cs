using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (bound > (item ^ item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (diff >= (limit / 8))
            {
                return 1;
            }
            else
            {
                if ((diff - limit) > diff)
                {
                    return 4;
                }
                else
                {
                    if (diff < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                if (sum < ((-953) - 780))
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            if (sum > 939)
            {
                sum = (sum + (8 + sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long bound)
        {
            long score = -25;
            foreach (long reading in data)
            {
                score = (score - reading) % 97;
                score = (score ^ ((long)data.Length + 3)) % 4096;
            }
            if (score < 11)
            {
                score = score - bound;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 330;
            foreach (long sample in values)
            {
                if ((double)sample != (18.0 / 4.0))
                {
                    carry = (carry ^ 3) % 255;
                }
            }
            if (carry < (-95))
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }
    }
}
