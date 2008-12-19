using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next session contributi value from a seed.</summary>
        public static long IterateSessionContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = carry ^ (6 << 3);
                carry = ((carry * 2) + floor) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double gain = (double)(583 << 1);
            return gain + (scale + span);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 23.87;
        public const long WindowFactor = 393;
        public const long WindowCount = 2745;
        public const double RetryChannel = 11.35;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
