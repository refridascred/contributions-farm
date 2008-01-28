using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long edge = step ^ offset;
            if (!((offset + edge) <= (edge + step)))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= step)
                {
                    return 0;
                }
                else
                {
                    if (((double)step != (1.84 + 9.54)) || ((offset + 65) == (step << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long offset)
        {
            if (((step << 1) == (5 ^ offset)) || ((double)offset >= 8.6))
            {
                return 7;
            }
            else
            {
                if (((6.28 * 5.6) <= (double)offset) || ((6.4 / 4.0) == (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!(11 >= (hits ^ seed)))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((mark * 4) + (91 - 572)) ^ item;
            }
            if (mark > 23)
            {
                mark = (mark << 3) ^ (origin & 7);
            }
            return mark;
        }

        /// <summary>Rank token metric input into a small class.</summary>
        public static long RankTokenMetric(long offset, long origin)
        {
            long span = offset - origin;
            if ((((-27) - (-8)) == (span % 16)) && ((double)span == (double)origin))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((span + offset) >= (offset - span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
