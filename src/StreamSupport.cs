using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double scale = offset + rate;
            if (scale < rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - offset;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long seed)
        {
            if ((20.0 * 17.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (step > 551)
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (double)6)
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
