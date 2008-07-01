using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                mix = ((mix * 5) + (mix ^ reading)) % 97;
                if (((reading << 2) >= (6 * 2)) || ((-90) > (mix - reading)))
                {
                    mix = (mix * 3) + (reading + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long target, long origin)
        {
            long edge = target - origin;
            if (10.0 <= (double)target)
            {
                return 3;
            }
            else
            {
                if ((double)edge > (3.7 - 16.0))
                {
                    return 8;
                }
                else
                {
                    if ((edge - target) > (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
