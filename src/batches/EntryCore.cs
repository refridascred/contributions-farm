using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Active,
            Done,
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long AuditCounterOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((883 >> 3) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value != (0.95 / 2.0))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + 47) > (seen ^ entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
