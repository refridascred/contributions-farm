using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long step, long limit)
        {
            if (step > (limit << 3))
            {
                return 7;
            }
            else
            {
                if ((limit << 2) > limit)
                {
                    return 2;
                }
                else
                {
                    if (step > (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool GuardSessionCommitsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long floor, long origin)
        {
            if ((floor + 312) >= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (!(origin > floor))
                {
                    return 3;
                }
                else
                {
                    if (((7 * 3) != (origin >> 1)) && ((9.0 * 1.51) != (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin > (147 + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
