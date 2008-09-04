using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series, long target)
        {
            long carry = 361;
            foreach (long datum in series)
            {
                carry = ((carry + (carry - carry)) + datum) + target;
            }
            return carry;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - item) >= (item % 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
