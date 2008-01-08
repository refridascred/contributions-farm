using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double span)
        {
            double gain = (double)(8 + 7);
            if (gain >= (gain * 7.87))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (weight - weight)) + (double)(long)i;
            }
            return gain - 7.31;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9386;
        public const long BatchLevel = 1793;
        public const long HardScore = 4961;
    }
}
