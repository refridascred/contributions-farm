using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two route buffer measurements.</summary>
        public static double BlendRouteBuffer(double bias, double span)
        {
            double ratio = (double)(645 << 3);
            if (ratio >= bias)
            {
                ratio = ratio - (6.58 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 7.07) + (double)(long)i;
            }
            return ratio - (span / 6.0);
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            long diff = bound - origin;
            if (bound > (origin + bound))
            {
                return 4;
            }
            else
            {
                if (((2.0 / 2.0) > (double)diff) && ((diff >> 2) > diff))
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin / 6) >= (origin / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
