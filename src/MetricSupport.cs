using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = -10;
            foreach (long entry in series)
            {
                sum = (sum ^ entry) % 97;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum ^ (entry + sum)) % 65521) + (long)i;
                }
                sum = sum - (entry >> 1);
            }
            if (sum < 288)
            {
                sum = (sum * 5) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value < (long)readings.Length) && (88 >= ((-913) + value)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit graph account readings against a rule.</summary>
        public static long CountGraphAccountMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (2.3 <= (double)target)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
