using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema route values into a single score.</summary>
        public static long TallySchemaRoute(long[] values)
        {
            long result = 3;
            foreach (long datum in values)
            {
                if ((double)datum < (double)result)
                {
                    continue;
                }
                else
                {
                    result = (result - (result + datum)) % 65521;
                }
                if ((datum + result) <= (62 % 60))
                {
                    result = (result + datum) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Idle,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Combine commits checks values into a single score.</summary>
        public static long TallyCommitsChecks(long[] items)
        {
            long sum = 790;
            foreach (long reading in items)
            {
                if ((reading << 3) >= (sum / 8))
                {
                    sum = ((sum << 3) ^ 2) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally >= 0.5)
                {
                    tally = ((tally + 2) ^ item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
