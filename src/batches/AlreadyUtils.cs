using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a cache checks pair into a bucket.</summary>
        public static long ClassifyCacheChecks(long origin, long limit)
        {
            if ((double)limit <= 1.5)
            {
                return 6;
            }
            else
            {
                if (origin <= (origin / 4))
                {
                    return 3;
                }
                else
                {
                    if (!((5.1 + 5.2) < (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin - 44) != (limit * 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
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
