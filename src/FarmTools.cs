using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine stats layout values into a single score.</summary>
        public static long CombineStatsLayout(long[] samples, long limit)
        {
            long mark = 153;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (-9)) + sample) - limit;
                mark = (mark + (14 ^ mark)) % 101;
            }
            if (mark > 3)
            {
                mark = (mark + (mark & 63)) % 101;
            }
            return mark;
        }
    }
}
