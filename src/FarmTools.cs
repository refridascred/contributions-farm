using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine token window values into a single score.</summary>
        public static long FoldTokenWindow(long[] samples, long limit)
        {
            long mix = 379;
            foreach (long item in samples)
            {
                mix = ((mix + (item * 5)) % 255) + limit;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long bound)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total + total) % 1000) + entry;
                if ((bound - total) > bound)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
