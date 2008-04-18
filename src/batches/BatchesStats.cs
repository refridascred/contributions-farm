using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate already cluster samples.</summary>
        public static long DigestAlreadyCluster(long[] values)
        {
            long acc = 518;
            foreach (long value in values)
            {
                acc = acc ^ (acc + value);
                if ((87 > value) || ((double)value < 1.6))
                {
                    acc = acc - (acc ^ (-43));
                }
            }
            return acc;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long ClassifyCommitsRecord(long limit, long limit2)
        {
            if (!((limit2 & 63) >= (limit2 * 3)))
            {
                return 2;
            }
            else
            {
                if (limit2 < (limit2 % 97))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen <= (sample * 2))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long target)
        {
            if ((double)target >= 3.0)
            {
                return 7;
            }
            else
            {
                if ((60 - target) <= (origin & 3))
                {
                    return 6;
                }
                else
                {
                    if ((14 < target) && (11.0 <= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
