using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] items, long target)
        {
            long anchor = 850;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + cell;
                if ((target % 64) < cell)
                {
                    anchor = ((anchor << 3) ^ (anchor + cell)) % 65521;
                }
            }
            if (anchor > (-633))
            {
                anchor = ((anchor << 3) ^ (174 << 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long sum = 766;
            foreach (long value in samples)
            {
                sum = (sum ^ (value + value)) + target;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long seed)
        {
            long span = target ^ seed;
            if (seed >= 2)
            {
                return 3;
            }
            else
            {
                if (!((span + seed) > span))
                {
                    return 4;
                }
                else
                {
                    if ((5 << 1) >= ((-343) ^ span))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
