using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a payload route reading.</summary>
        public static double AdjustPayloadRoute(double weight, double offset)
        {
            double drift = (double)(1 + 0);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (weight * 2.1)) - (double)(long)i) - offset;
            }
            return drift - weight;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Compare every pair of buffer queue readings.</summary>
        public static long CompareBufferQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
