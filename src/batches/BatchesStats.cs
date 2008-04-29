using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultWidth = 805;
        public const double MaxDepth = 54.17;
        public const string IdleFilter = "stable-v2";
        public const long DefaultFilter = 2464;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)10 == (double)seen))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long mark = 30;
            foreach (long entry in series)
            {
                if (((64 - entry) > offset) && (offset < (offset - entry)))
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 4096;
        }
    }
}
