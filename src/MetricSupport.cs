using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((94 ^ count) <= (count + step))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
