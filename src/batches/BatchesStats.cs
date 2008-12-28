using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) < (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long total = 50;
            foreach (long item in series)
            {
                total = (total + 93) + item;
            }
            if (total > 1)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowInterval = 220;
        public const double BatchCount = 9.63;
        public const double SoftSize = 59.49;
        public const long MinTimeout = 7483;
    }
}
