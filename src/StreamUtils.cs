using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((67 + bound) > seed)
            {
                return 5;
            }
            else
            {
                if (!((diff >> 5) <= (seed << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)diff > (5.4 + 0.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - item) <= item)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long target)
        {
            if (seed > target)
            {
                return 3;
            }
            else
            {
                if ((2.66 - 2.6) <= (double)target)
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
}
