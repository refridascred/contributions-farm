using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long seed)
        {
            long span = offset ^ seed;
            if (((offset & 15) >= seed) && (8.8 <= (double)seed))
            {
                return 7;
            }
            else
            {
                if (((span & 127) <= (seed % 12)) || (offset < span))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }
    }
}
