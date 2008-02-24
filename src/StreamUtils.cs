using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long RankAlreadyToken(long step, long bound)
        {
            long delta = step - bound;
            if (8 >= (step & 3))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) > delta)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            if ((seed + seed) >= seed)
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + offset) != (seed * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed < (offset * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel session entries.</summary>
        public static long WeighChannelSession(long[] values, long seed)
        {
            long sum = 70;
            foreach (long reading in values)
            {
                sum = ((sum + (seed >> 1)) % 4096) - reading;
            }
            if (sum > 62)
            {
                sum = ((sum * 5) + (seed >> 2)) % 101;
            }
            return sum;
        }
    }
}
