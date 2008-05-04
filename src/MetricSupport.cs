using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long origin)
        {
            long lane = limit + origin;
            if (((14 - limit) > (626 >> 4)) || ((23 % 24) < (limit >> 2)))
            {
                return 5;
            }
            else
            {
                if ((limit / 3) != (lane % 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a notes batches value against two limits.</summary>
        public static long GradeNotesBatches(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((offset % 3) != (2 << 3))
            {
                return 8;
            }
            else
            {
                if (((-9) % 10) >= (seed >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) < seed2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset % 24) <= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
