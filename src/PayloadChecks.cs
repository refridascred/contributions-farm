using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels)
        {
            long mix = -350;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length < (double)mix)
                {
                    mix = (mix ^ (mix ^ 29)) % 101;
                }
                if ((value ^ value) == (value & 1))
                {
                    break;
                }
            }
            return mix;
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
