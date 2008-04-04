using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 2926;
        public const long WindowTools = 7975;
        public const long IdleTools = 693;
        public const long WindowSize = 7239;
        public const long MinTools = 3565;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long origin)
        {
            long state = 550;
            foreach (long reading in series)
            {
                if (origin > reading)
                {
                    state = (state * 2) + reading;
                }
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((seed - seed) < (56 % 97))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if ((seed ^ 860) > (seed - bound2))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 == (1.2 - 15.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 3) <= (4 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
