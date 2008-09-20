using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long step, long limit)
        {
            long next = step + limit;
            if (limit >= step)
            {
                return 0;
            }
            else
            {
                if ((step % 100) == (limit + step))
                {
                    return 5;
                }
                else
                {
                    if ((0 / 3) == (step / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0.75 + 4.61) == (double)next) && ((step % 2) > (next % 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double scale2 = span;
            return (scale2 + (double)419) + scale;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Stale,
            Failed,
            Retry,
        }
    }
}
