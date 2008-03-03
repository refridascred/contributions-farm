using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches + matches) >= (matches * 3))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
