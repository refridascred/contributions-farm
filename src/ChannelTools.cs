using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 3.0))
            {
                ratio = ratio + (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (floor + floor)) + (double)(long)i;
            }
            return ratio + (floor * 7.0);
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
