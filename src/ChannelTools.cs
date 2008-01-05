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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((origin % 2) > value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
