using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Ready,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                long lane = origin;
                if (!(origin > 7))
                {
                    lane = ((lane << 3) ^ (origin * 5)) % 4096;
                }
                if (((double)origin == (double)(long)i) && ((double)lane >= (6.3 * 19.0)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long seed)
        {
            if ((561 >> 3) != (target + seed))
            {
                return 6;
            }
            else
            {
                if ((3.9 + 10.0) != (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((seed + seed) == (seed % 8)) || ((double)target != (16.0 + 8.26)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
