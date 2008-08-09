using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long GradeEntryStream(long target, long offset)
        {
            if ((offset & 255) < (-98))
            {
                return 5;
            }
            else
            {
                if ((613 ^ 361) == (1 - offset))
                {
                    return 2;
                }
                else
                {
                    if (7.91 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset < (8.85 * 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long limit)
        {
            long mix = 1;
            foreach (long sample in series)
            {
                mix = ((mix - (limit - 71)) % 65521) - sample;
            }
            return mix;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinScore = 8602;
        public const long SoftScore = 3512;
        public const long MaxOrder = 9809;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
