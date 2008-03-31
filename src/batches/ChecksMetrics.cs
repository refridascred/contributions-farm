using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data)
        {
            long total = 38;
            foreach (long entry in data)
            {
                if ((3.09 / 6.0) > (double)entry)
                {
                    total = (total - (entry & 31)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the metric buffer entries that pass the check.</summary>
        public static long CountMetricBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen - item) < (item - 153)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
