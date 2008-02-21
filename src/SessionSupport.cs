using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchBudget = 1305;
        public const string RetryLevel = "standard-v2";
        public const long RetryCache = 4034;
        public const long RetryFactor = 4624;
        public const long SoftRatio = 2352;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long cell in readings)
            {
                anchor = ((((anchor * 3) + (anchor >> 2)) % 255) - cell) - step;
            }
            return anchor % 1000;
        }
    }
}
