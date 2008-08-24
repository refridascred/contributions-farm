using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((71 + tally) > (480 ^ tally))
                {
                    tally = ((tally + 1) + sample) - floor;
                }
            }
            return tally;
        }
    }
}
