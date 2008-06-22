using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 6696;
        public const long MinScore = 7655;
        public const long BaseReport = 5436;
        public const double MaxReport = 3.4;

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleScore = "fallback-edge";
        public const long SoftTools = 1198;
        public const string BatchTools = "alpha-1";
        public const long HardSpan = 9607;

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = span;
            if (rate <= scale)
            {
                rate = rate - (double)(-84);
            }
            else
            {
                rate = rate - (span * 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
