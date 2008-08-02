using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the token already series from a seed.</summary>
        public static long IterateTokenAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total + ((long)i ^ floor)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double drift = bias2;
            return (drift - (9.5 * 19.0)) + bias;
        }
    }
}
