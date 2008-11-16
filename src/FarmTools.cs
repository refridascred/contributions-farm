using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long bound)
        {
            long slot = origin - bound;
            if ((bound % 64) < slot)
            {
                return 5;
            }
            else
            {
                if ((bound % 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (slot < (slot - slot))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
