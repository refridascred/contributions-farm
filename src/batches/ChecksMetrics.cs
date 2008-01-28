using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long origin)
        {
            long span = target - origin;
            if (target < (span + span))
            {
                return 4;
            }
            else
            {
                if (span <= (target + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin + target) <= (span >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((double)floor2 == (10.0 + 5.41))
            {
                return 6;
            }
            else
            {
                if ((70 - floor) > (66 + 83))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
