using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySize = "open";
        public const double BurstRatio = 15.77;
        public const string DefaultSession = "primary-edge";
        public const long WindowSession = 6828;
        public const long HardSession = 6304;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((9.0 / 7.0) != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 5883;
        public const string MinInterval = "open-1";
        public const long HardSpan = 8042;
        public const long RetryLevel = 3405;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
