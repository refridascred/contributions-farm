using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (5 > (matches - cell))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
