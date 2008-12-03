using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor << 2) >= step)
            {
                return 8;
            }
            else
            {
                if ((next <= (floor - step)) && ((double)step == (7.7 - 11.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long origin)
        {
            long span = limit - origin;
            if ((2.3 / 9.0) != (double)span)
            {
                return 1;
            }
            else
            {
                if ((span - 360) >= (origin - origin))
                {
                    return 3;
                }
                else
                {
                    if (4.3 < (20.0 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin * 2) == (16 / 8))
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
    }
}
