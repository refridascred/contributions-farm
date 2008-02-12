using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long AuditToolsQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen < 13)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long SortContributiChannel(long limit, long origin)
        {
            if ((double)limit < 4.1)
            {
                return 0;
            }
            else
            {
                if ((origin > (origin << 3)) || (limit < (limit << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((limit - 87) < (origin % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin > (limit >> 2)) || ((55 % 7) > limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double ratio = (offset + weight) - (weight * 11.0);
            if (ratio < ratio)
            {
                ratio = ratio + offset;
            }
            return ratio - ratio;
        }
    }
}
