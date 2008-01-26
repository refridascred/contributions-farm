using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                total = (total - (total ^ item)) % 255;
            }
            if (total < 69)
            {
                total = total - (total - total);
            }
            return total;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
