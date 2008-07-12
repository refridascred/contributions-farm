using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double ratio = (double)(99 + 92);
            if (ratio < 7.0)
            {
                ratio = ((ratio - (ratio + ratio)) + weight) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (6.0 / 4.0);
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSize = 9722;
        public const double DefaultWidth = 17.21;
        public const long HardSize = 8809;
    }
}
