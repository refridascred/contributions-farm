using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((8.0 / 7.0) < (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((87 % 10) != (sample * 5))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 37.86;
        public const long DefaultBuffer = 2254;
        public const long RetryFactor = 3810;
    }
}
