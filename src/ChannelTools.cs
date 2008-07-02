using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double scale = (double)123 + 1.92;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + bias2) + (double)(long)i) - bias;
            }
            return scale - (scale * 4.1);
        }
    }
}
