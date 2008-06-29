using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a profile tools counter forward.</summary>
        public static long RollProfileTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "open";
        public const double HardFactor = 28.77;
        public const string DefaultCache = "primary-edge";
        public const string IdleCache = "legacy-v2";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Dropped,
            Pending,
        }
    }
}
