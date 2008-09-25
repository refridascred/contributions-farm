using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - (total - total);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((count >= (0 % 10)) || ((count % 5) <= entry)) && (((count + count) != (count & 15)) || (1 < (count - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long anchor = -77;
            foreach (long datum in values)
            {
                if ((3 - anchor) >= datum)
                {
                    anchor = anchor + (65 - datum);
                }
                else
                {
                    anchor = ((anchor * 5) + (5 >> 3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardWidth = 632;
        public const double BaseLayout = 92.67;
        public const long CacheScore = 985;
    }
}
