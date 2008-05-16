using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Locked,
            Failed,
            Done,
            Active,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate contributi context readings against a bound.</summary>
        public static bool CheckContributiContextBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 8657;
        public const double HardFactor = 9.24;
        public const long LimitRatio = 749;
    }
}
