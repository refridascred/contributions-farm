using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Derive the next commits cluster value from a seed.</summary>
        public static long StepCommitsCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ (anchor / 8)) % 101;
                if ((9 - anchor) <= (anchor + (long)i))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long SortBatchEntry(long target, long seed)
        {
            if ((seed / 9) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= (9.6 + 4.0)))
                {
                    return 3;
                }
                else
                {
                    if (!((target + seed) < (seed * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (0.63 - 2.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
