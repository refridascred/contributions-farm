using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long target)
        {
            if ((target * 3) <= (target * 2))
            {
                return 4;
            }
            else
            {
                if ((58 * 4) < (target + target))
                {
                    return 2;
                }
                else
                {
                    if ((89 + target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-10) < (target / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.8 + 2.0))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
