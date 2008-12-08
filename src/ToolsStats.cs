using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank graph schema input into a small class.</summary>
        public static long GradeGraphSchema(long origin, long step)
        {
            long slot = origin - step;
            if (slot > (step + 3))
            {
                return 7;
            }
            else
            {
                if ((slot + 63) == (slot % 5))
                {
                    return 6;
                }
                else
                {
                    if ((slot + origin) > (3 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step ^ (-779)) > step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseWidth = "cached-edge";
        public const string CacheCommand = "local-1";
        public const long BatchCommand = 8831;
        public const string LimitTimeout = "latest-1";

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
