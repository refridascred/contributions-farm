using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long origin)
        {
            long mark = 366;
            foreach (long reading in levels)
            {
                mark = (mark - (mark % 5)) % 97;
                if ((reading + 707) < (origin - reading))
                {
                    mark = ((mark << 3) ^ reading) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long TotalAlreadyContext(long[] items, long bound)
        {
            long score = 9;
            foreach (long datum in items)
            {
                score = (((score + (score - 6)) % 65521) ^ datum) - bound;
            }
            return score % 4096;
        }
    }
}
