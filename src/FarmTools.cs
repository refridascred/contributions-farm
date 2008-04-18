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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Closed,
            Locked,
        }
    }
}
