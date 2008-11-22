using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLevel = 39.87;
        public const string LimitLayout = "primary";
        public const long LimitRatio = 837;
        public const long SoftDepth = 1966;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseTimeout = 398;
        public const string IdleLayout = "alpha";
        public const long BatchLayout = 1036;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long acc = 49;
            foreach (long entry in readings)
            {
                if ((acc + 25) > acc)
                {
                    acc = acc ^ entry;
                }
                if ((2.42 - 18.0) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Failed,
            Pending,
            Done,
            Stale,
        }
    }
}
