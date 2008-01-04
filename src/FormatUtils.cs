using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 885;
        public const long MinReport = 1215;
        public const double BaseTimeout = 18.51;
        public const long BaseReport = 7548;
        public const long DefaultSpan = 7232;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((1.3 + 1.95) > (double)datum) || (((double)(long)items.Length == (10.0 - 1.7)) && ((limit * 5) > datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long seed)
        {
            long gap = origin + seed;
            if ((seed + 90) >= (7 + gap))
            {
                return 5;
            }
            else
            {
                if (((seed + gap) < (gap % 2)) && ((-351) > (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    if ((6.45 / 6.0) >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed >= (origin << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Queued,
            Stale,
            Locked,
        }
    }
}
