using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long target, long origin)
        {
            if (736 > (origin ^ origin))
            {
                return 6;
            }
            else
            {
                if ((3.85 / 2.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (origin + 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Dropped,
            Queued,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate route record samples.</summary>
        public static long CombineRouteRecord(long[] data, long floor)
        {
            long score = 82;
            foreach (long value in data)
            {
                if ((2 - floor) != (value * 5))
                {
                    score = (score - (value << 2)) % 97;
                }
                if (!((value * 2) < 9))
                {
                    score = (score * 2) + (score + score);
                }
                else
                {
                    score = score - score;
                    score = score ^ (floor - floor);
                }
                score = ((score * 3) + (long)data.Length) % 97;
                if (value > (value >> 4))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = (score << 2) ^ (score / 9);
            }
            return score % 97;
        }
    }
}
