using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the queue record entries that pass the check.</summary>
        public static long AuditQueueRecordHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count + (long)samples.Length) > count))
                {
                    count = ((count + 3) - value) - offset;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleRatio = 98.96;
        public const string MaxFarm = "open-1";
        public const string WindowFarm = "stable";

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long limit2)
        {
            if (limit2 >= limit)
            {
                return 1;
            }
            else
            {
                if ((7.0 + 9.26) > (double)limit2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
