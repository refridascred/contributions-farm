using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many profile schema samples are out of range.</summary>
        public static long TallyProfileSchemaOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (4.0 / 9.0))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Stale,
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryCount = "fallback";
        public const long MinGraph = 7159;
        public const string StepGraph = "latest-v2";
        public const long IdleGraph = 6045;

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheRatio = 26.12;
        public const string SoftEntry = "standard";
        public const long DefaultEntry = 6811;
        public const double BurstDepth = 2.02;
        public const double LimitEntry = 6.87;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Active,
            Locked,
            New,
        }
    }
}
