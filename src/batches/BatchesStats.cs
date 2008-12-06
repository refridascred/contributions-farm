using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine account support values into a single score.</summary>
        public static long CombineAccountSupport(long[] levels, long target)
        {
            long mark = 2;
            foreach (long datum in levels)
            {
                mark = (mark + target) ^ datum;
            }
            if (mark < 2)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long limit)
        {
            long edge = seed + limit;
            if (edge < 742)
            {
                return 7;
            }
            else
            {
                if (!((seed >> 5) < limit))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Pending,
            Stale,
        }
    }
}
