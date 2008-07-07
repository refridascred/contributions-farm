using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Synced,
            Queued,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long score = 848;
            foreach (long cell in samples)
            {
                if ((9.7 / 2.0) <= (double)seed)
                {
                    score = ((score - ((-83) - seed)) % 1000) + cell;
                }
            }
            if (score < 8)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
