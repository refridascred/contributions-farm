using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank session profile input into a small class.</summary>
        public static long RankSessionProfile(long offset, long target)
        {
            if ((offset + target) >= (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((2 >> 3) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 2) != (offset + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target < 0.7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Dropped,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels, long origin)
        {
            long sum = 24;
            foreach (long datum in levels)
            {
                if (((4.91 + 5.0) == (double)(long)levels.Length) || ((datum + datum) < datum))
                {
                    sum = ((sum << 3) ^ origin) % 1000;
                    sum = ((sum * 5) + (datum >> 3)) % 65521;
                }
                if ((double)675 >= (double)datum)
                {
                    sum = sum + (67 & 127);
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 13.0)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
