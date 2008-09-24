using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + count) >= bound)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "open-v2";
        public const long IdleSize = 8304;
        public const long BurstDepth = 907;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long limit)
        {
            long mix = 37;
            foreach (long item in items)
            {
                mix = (mix ^ (82 ^ limit)) ^ item;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long AuditOrderContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally < (reading >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
