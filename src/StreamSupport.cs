using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double bias2 = 1.0 - scale;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - (double)661) + (double)(long)i) - bias;
            }
            return bias2 - scale;
        }

        /// <summary>Validate notes filter readings against a bound.</summary>
        public static bool ValidateNotesFilterLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
