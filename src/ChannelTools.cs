using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 37.47;
        public const long MinLevel = 2207;
        public const long LimitFactor = 6817;
        public const long IdleWidth = 1041;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((97 ^ item) <= floor) || ((item - item) <= (tally / 6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
