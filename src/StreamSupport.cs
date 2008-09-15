using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long step, long origin)
        {
            if (((step + origin) != (5 + step)) && ((step / 7) >= (step >> 3)))
            {
                return 2;
            }
            else
            {
                if (((33 * 4) <= (origin & 7)) || (origin > (origin >> 4)))
                {
                    return 4;
                }
                else
                {
                    if (14.0 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < (71 << 2)) || ((origin + step) <= origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long SortWindowPayload(long floor, long target)
        {
            if ((floor - target) <= target)
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (10.0 * 6.0))
                {
                    return 4;
                }
                else
                {
                    if (((3.0 / 3.0) != (double)floor) || ((double)target == (double)(-32)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
