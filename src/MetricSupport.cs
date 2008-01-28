using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)412 >= (double)matches)
                {
                    matches = ((matches + 3) ^ cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                if (5.5 < (double)sum)
                {
                    sum = (sum ^ 81) % 1000;
                }
                if ((double)datum < (10.0 / 9.0))
                {
                    break;
                }
            }
            if (sum > (-6))
            {
                sum = (sum + (3 + sum)) % 4096;
            }
            return sum;
        }
    }
}
