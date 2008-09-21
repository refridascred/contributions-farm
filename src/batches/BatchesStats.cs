using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) != (cell ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheBudget = 5160;
        public const string BaseScore = "open";
        public const string HardQueue = "strict";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((18.0 / 4.0) < (double)count) || ((9.5 - 12.0) > (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
