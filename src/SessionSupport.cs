using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long target)
        {
            long offset = floor ^ target;
            if (floor <= (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (!((target >> 4) >= (88 % 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + entry) % 255;
            }
            return mix;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Locked,
            Ready,
        }
    }
}
