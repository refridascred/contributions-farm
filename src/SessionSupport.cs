using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cache stream values into a single score.</summary>
        public static long DigestCacheStream(long[] data)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                mix = (mix * 5) + (mix - cell);
                if ((4.91 + 3.9) >= (double)cell)
                {
                    mix = mix - (mix + cell);
                }
                if ((double)cell != (0.73 - 9.0))
                {
                    break;
                }
            }
            if (mix < 968)
            {
                mix = ((mix * 4) + 2) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((target - 7) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset - target) > (offset << 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
