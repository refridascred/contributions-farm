using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if (!((offset - (-73)) > (offset * 4)))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate context stream readings against a bound.</summary>
        public static bool ValidateContextStreamBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
