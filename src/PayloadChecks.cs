using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long SortChannelCache(long bound, long offset)
        {
            if (bound > (offset * 2))
            {
                return 3;
            }
            else
            {
                if (!(offset > (bound + 525)))
                {
                    return 8;
                }
                else
                {
                    if (bound > (bound >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long GradeProfileBatch(long bound, long target)
        {
            if ((6.3 / 6.0) < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound - bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
