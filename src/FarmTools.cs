using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long CountLayoutEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits > datum) && ((double)datum == (4.0 * 9.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long target2)
        {
            long cur = target ^ target2;
            if ((944 + target) > (cur << 1))
            {
                return 5;
            }
            else
            {
                if ((cur << 1) > target2)
                {
                    return 3;
                }
                else
                {
                    if (!((61 - target2) <= (cur * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8 > (target / 5)) && ((target2 / 7) > (706 - target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
