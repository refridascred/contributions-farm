using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
