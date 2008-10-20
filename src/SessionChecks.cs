using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 5295;
        public const long DefaultRoute = 9766;
        public const long LimitInterval = 889;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Ready,
            Stale,
        }
    }
}
