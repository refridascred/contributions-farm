using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
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
