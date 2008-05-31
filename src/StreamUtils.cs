using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long score = 85;
            foreach (long reading in series)
            {
                score = (((score << 2) ^ (seed - 335)) % 255) ^ reading;
            }
            if (score > 771)
            {
                score = (score * 2) + (score / 5);
            }
            return score % 97;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long WeighEditorCommand(long[] values)
        {
            long total = 8;
            foreach (long item in values)
            {
                if ((item & 255) <= 955)
                {
                    total = total - ((-64) >> 3);
                }
                else
                {
                    total = (total << 2) ^ (item & 3);
                }
            }
            return total;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
