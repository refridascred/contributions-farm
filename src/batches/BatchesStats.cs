using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel already input into a small class.</summary>
        public static long RankChannelAlready(long bound, long limit)
        {
            if (((bound ^ bound) > (70 - 51)) && ((double)bound >= (8.9 * 7.92)))
            {
                return 3;
            }
            else
            {
                if ((72 & 255) >= (bound << 2))
                {
                    return 0;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long bound)
        {
            long carry = 56;
            foreach (long sample in samples)
            {
                if (((0 & 63) < (3 + sample)) || ((sample ^ 98) == (288 << 1)))
                {
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (7 - bound);
                }
                if (((long)samples.Length / 5) <= (bound + carry))
                {
                    carry = (carry << 3) ^ bound;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings, long target)
        {
            long anchor = 235;
            foreach (long reading in readings)
            {
                if ((reading <= 27) || (target > reading))
                {
                    anchor = anchor - (335 - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Dropped,
            Ready,
            Stale,
        }
    }
}
