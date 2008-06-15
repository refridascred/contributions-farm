using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (floor + weight) - (weight * 9.0);
            if (gain <= floor)
            {
                gain = gain - (double)238;
            }
            return gain - 6.75;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Locked,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (3.57 + 3.9))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
