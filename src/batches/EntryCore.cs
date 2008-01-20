using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long limit)
        {
            if ((target + limit) > (9 * 2))
            {
                return 0;
            }
            else
            {
                if ((target + target) > (limit % 12))
                {
                    return 3;
                }
                else
                {
                    if ((target >= limit) || ((limit + limit) <= (target + 9)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit / 6) < (limit * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            New,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 79.68;
        public const long BatchSize = 5926;
        public const double MaxSpan = 60.81;
        public const long RetrySize = 975;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
