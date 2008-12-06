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

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = (total + ((long)i & 127)) % 4096;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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
