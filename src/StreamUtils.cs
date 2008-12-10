using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a graph order value against two limits.</summary>
        public static long GradeGraphOrder(long seed, long limit)
        {
            if (!((seed + limit) != (577 + 81)))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 60) != (limit ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long target)
        {
            long lane = offset - target;
            if (((lane - offset) <= (211 - target)) || ((7.5 * 5.18) >= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((1.0 + 6.1) > (double)lane)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
