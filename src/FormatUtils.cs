using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Closed,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            New,
            Done,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long offset2)
        {
            if ((double)offset2 == (double)135)
            {
                return 1;
            }
            else
            {
                if (((offset2 >> 1) == (offset2 << 3)) || (offset >= offset2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long floor)
        {
            long edge = seed - floor;
            if (((edge * 4) <= (edge + 871)) || (floor > (edge >> 4)))
            {
                return 8;
            }
            else
            {
                if ((edge - edge) != (9 << 1))
                {
                    return 1;
                }
                else
                {
                    if (6.55 < (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + edge) <= (floor ^ edge))
                        {
                            return 3;
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
