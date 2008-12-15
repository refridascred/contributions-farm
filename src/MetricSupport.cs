using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 979;
            foreach (long cell in values)
            {
                mark = mark - mark;
                if (mark > (cell >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
