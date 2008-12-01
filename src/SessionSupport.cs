using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (((-74) + offset) != (delta * 4))
            {
                return 2;
            }
            else
            {
                if ((offset2 - delta) > offset2)
                {
                    return 8;
                }
                else
                {
                    if (!((246 + 280) != (offset2 + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((7.3 / 9.0) == (double)offset2) && ((offset / 5) <= (1 & 63)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((71 >> 4) < mark)
                {
                    mark = (mark - offset) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark << 3)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
