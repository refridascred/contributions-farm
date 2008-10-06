using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((bound << 3) < (92 % 24)) || ((mix >> 3) != ((long)i / 3)))
                {
                    mix = ((mix * 5) + bound) % 255;
                }
                mix = (mix ^ mix) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((72 & 15) >= (origin & 15))
            {
                return 0;
            }
            else
            {
                if (((101 << 2) <= (bound - bound)) || ((477 % 7) != (origin << 1)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
