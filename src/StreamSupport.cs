using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 2293;
        public const long CacheRatio = 2575;
        public const long BaseScore = 4286;
        public const long StepCache = 4153;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = floor;
            if (scale < (double)(-22))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - floor;
            }
            return scale + 5.0;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
