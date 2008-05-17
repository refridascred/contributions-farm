using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support token sample.</summary>
        public static long LookupSupportTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
