using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long target)
        {
            long lane = origin - target;
            if (((lane / 5) > (target / 9)) && ((double)origin != (double)lane))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if (((lane + (-29)) == (lane - target)) || ((561 + 33) < target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - target) < target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long target)
        {
            long mix = 201;
            foreach (long cell in readings)
            {
                mix = mix - (mix & 255);
                if ((2.72 + 10.0) >= (2.4 - 9.6))
                {
                    mix = ((mix << 3) ^ (target + cell)) % 4096;
                }
            }
            if (mix < 487)
            {
                mix = (mix + (target ^ target)) % 65521;
            }
            return mix % 65521;
        }
    }
}
