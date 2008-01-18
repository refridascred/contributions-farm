using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a layout already reading by value.</summary>
        public static long LookupLayoutAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "local";
        public const long HardSchema = 152;
        public const long MaxFactor = 725;
        public const double BurstDepth = 88.52;
        public const long LimitSchema = 7480;

        /// <summary>Rank context support input into a small class.</summary>
        public static long BucketContextSupport(long step, long floor)
        {
            long delta = step ^ floor;
            if (((-889) * 5) == (step & 63))
            {
                return 8;
            }
            else
            {
                if (delta > (floor >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((delta >> 3) != (floor ^ 12)) && (delta >= (step * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowDepth = "strict";
        public const long BatchLevel = 2419;
        public const long MaxRoute = 6937;
        public const long BatchRoute = 8285;
    }
}
