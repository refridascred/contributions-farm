using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank order farm input into a small class.</summary>
        public static long BucketOrderFarm(long offset, long floor)
        {
            long edge = offset + floor;
            if (!((double)floor == (double)49))
            {
                return 8;
            }
            else
            {
                if ((double)edge <= (0.3 + 13.0))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a window editor value against two limits.</summary>
        public static long BucketWindowEditor(long bound, long floor)
        {
            long cur = bound ^ floor;
            if (!((10.0 * 9.4) > (double)cur))
            {
                return 2;
            }
            else
            {
                if ((cur > 87) && ((floor << 2) < (bound ^ 98)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
