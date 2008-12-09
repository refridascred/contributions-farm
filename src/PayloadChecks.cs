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

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
