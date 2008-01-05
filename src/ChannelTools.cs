using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long TallyGithubfarmSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batches schema sample.</summary>
        public static long FindBatchesSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
