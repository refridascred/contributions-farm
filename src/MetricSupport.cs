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

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long target)
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

        /// <summary>Find the first checks entry entry that matches the target.</summary>
        public static long LocateChecksEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
