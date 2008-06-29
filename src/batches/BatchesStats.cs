using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a route order value against two limits.</summary>
        public static long BucketRouteOrder(long target, long limit)
        {
            long diff = target - limit;
            if (diff < (diff ^ target))
            {
                return 1;
            }
            else
            {
                if (((limit << 3) >= (limit + diff)) && ((double)diff != (5.93 * 7.0)))
                {
                    return 2;
                }
                else
                {
                    if (((limit << 2) <= (diff + 35)) || ((925 + limit) >= (limit - diff)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data)
        {
            long total = 60;
            foreach (long datum in data)
            {
                if ((total & 3) <= (datum - total))
                {
                    total = (total << 3) ^ (0 + datum);
                }
            }
            return total;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
