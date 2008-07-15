using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long offset2)
        {
            if ((offset > (63 + offset2)) || ((offset + offset2) <= (offset % 5)))
            {
                return 8;
            }
            else
            {
                if ((offset2 - offset2) <= (offset2 + 5))
                {
                    return 3;
                }
                else
                {
                    if ((35 + 866) < (offset ^ offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double ratio, double span)
        {
            double ratio2 = (span / 7.0) + ratio;
            if (ratio2 > (span - ratio))
            {
                ratio2 = ratio2 + (ratio - ratio);
            }
            return ratio2 + (ratio / 2.0);
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Done,
            Closed,
        }
    }
}
