using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a stream batch sample.</summary>
        public static long LocateStreamBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = mix ^ (mix + mix);
                if (!((datum - datum) > 3))
                {
                    mix = ((mix * 3) + datum) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values)
        {
            long anchor = 65;
            foreach (long sample in values)
            {
                if (anchor <= sample)
                {
                    anchor = (anchor - (anchor - 36)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (sample + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i % 60) > (0 + target)) && ((9.9 - 1.7) != (double)carry))
                {
                    carry = (carry * 4) + (target + (long)i);
                    carry = carry ^ (target >> 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
