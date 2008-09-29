using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)989 > (double)item)
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Retry,
            Draft,
        }
    }
}
