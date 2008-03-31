using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
