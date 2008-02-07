using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitDepth = 7507;
        public const double DefaultInterval = 4.81;
        public const string HardTimeout = "standard";
        public const string HardCount = "strict-v2";
        public const long RetrySize = 7296;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer tools counter forward.</summary>
        public static long DeriveBufferTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ result) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
