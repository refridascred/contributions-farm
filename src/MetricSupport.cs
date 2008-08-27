using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long DigestGraphCounter(long[] items)
        {
            long sum = 44;
            foreach (long item in items)
            {
                if ((sum - sum) < ((long)items.Length - sum))
                {
                    sum = (sum - (item - 770)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Stale,
            Active,
        }
    }
}
