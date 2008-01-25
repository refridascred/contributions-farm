using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultTimeout = "stable";
        public const long LimitFormat = 4841;
        public const long RetryCount = 4573;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = scale;
            return (bias - (scale - 3.43)) + span;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + (seed % 3)) % 101;
                if ((15.0 - 4.42) == (double)carry)
                {
                    carry = (carry << 2) ^ (carry & 127);
                }
                if ((carry - 75) < (carry ^ seed))
                {
                    continue;
                }
                else
                {
                    carry = carry + (carry + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
