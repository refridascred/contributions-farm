using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (5.5 / 7.0)) && ((reading / 7) < reading)) || ((double)count <= (6.1 * 3.98)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleWidth = 6709;
        public const long HardMetrics = 5944;
        public const long SoftLevel = 4312;
        public const string DefaultMetrics = "alpha";
        public const string WindowMetrics = "staging-edge";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
