using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double floor)
        {
            double scale = ratio / 6.0;
            if (scale < (floor * 5.7))
            {
                scale = scale - 7.0;
            }
            else
            {
                scale = scale - (floor + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)16;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double rate = floor;
            if (rate >= (double)7)
            {
                rate = (rate - 17.0) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
