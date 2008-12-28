using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 4268;
        public const long WindowCache = 1704;
        public const double DefaultCache = 40.73;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Roll a schema already counter forward.</summary>
        public static long RollSchemaAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 101;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double bias = (double)(0 + (-87));
            return ((bias - (double)245) + gain) + offset;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Paused,
        }
    }
}
