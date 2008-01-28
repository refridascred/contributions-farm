using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 1485;
        public const long LimitWidth = 851;
        public const long BurstStats = 2323;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long anchor = 53;
            foreach (long value in readings)
            {
                anchor = (((anchor * 2) + floor) % 101) ^ value;
            }
            return anchor;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
