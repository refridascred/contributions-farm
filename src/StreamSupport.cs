using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count already buffer pairs that satisfy a relation.</summary>
        public static long MatchAlreadyBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
