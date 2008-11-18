using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of graph support readings.</summary>
        public static long WeighGraphSupport(long[] items)
        {
            long state = -5;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length > (8.3 / 6.0))
                {
                    state = (state * 4) + (cell << 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Idle,
        }
    }
}
