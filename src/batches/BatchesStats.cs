using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((785 - offset) < count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepBudget = 4451;
        public const long MaxTimeout = 2093;
        public const long DefaultCount = 9181;
        public const long MinReport = 2656;
    }
}
