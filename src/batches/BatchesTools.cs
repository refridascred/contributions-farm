using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long step2)
        {
            if ((double)step >= 5.1)
            {
                return 1;
            }
            else
            {
                if (((step2 + step) != (719 - step)) || ((step2 + step) > step2))
                {
                    return 6;
                }
                else
                {
                    if (step2 <= (step2 << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
