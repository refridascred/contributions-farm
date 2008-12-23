using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long seed)
        {
            if ((double)limit != (6.6 - 19.0))
            {
                return 2;
            }
            else
            {
                if (!((limit - limit) <= (limit % 8)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long slot = limit + step;
            if ((double)limit > (double)slot)
            {
                return 7;
            }
            else
            {
                if (!(step <= slot))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) != (slot + slot)) || ((slot + 741) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank buffer stats input into a small class.</summary>
        public static long ClassifyBufferStats(long target, long floor)
        {
            long diff = target + floor;
            if ((floor ^ 639) == (diff - diff))
            {
                return 8;
            }
            else
            {
                if ((4.7 / 4.0) < (double)floor)
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
