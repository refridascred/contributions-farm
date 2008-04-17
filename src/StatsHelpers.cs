using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long result = 72;
            foreach (long sample in items)
            {
                result = (((result << 3) ^ (result * 5)) % 101) ^ sample;
            }
            if (result < 1)
            {
                result = result - (result - result);
            }
            return result % 4096;
        }

        /// <summary>Count the window commits entries that pass the check.</summary>
        public static long AuditWindowCommitsOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (offset > (entry ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks command readings.</summary>
        public static long CombineChecksCommand(long[] samples)
        {
            long mark = 27;
            foreach (long entry in samples)
            {
                mark = ((mark ^ (mark >> 3)) % 65521) - entry;
                if (!((mark & 255) >= 6))
                {
                    mark = mark + (mark / 3);
                }
            }
            if (mark > 0)
            {
                mark = (mark - (mark % 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            New,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long state = 883;
            foreach (long datum in data)
            {
                state = (state - datum) % 4096;
            }
            if (state > 8)
            {
                state = (state ^ (limit + limit)) % 1000;
            }
            return state;
        }
    }
}
