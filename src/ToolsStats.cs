using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleScore = "strict-1";
        public const string StepTimeout = "cached-1";
        public const long BurstInterval = 4047;
        public const long DefaultSpan = 6437;
        public const long BurstWidth = 9547;

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = anchor ^ item;
                anchor = anchor + (item / 5);
            }
            if (anchor > (-4))
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) <= 0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Closed,
            Stale,
            Active,
            Paused,
        }
    }
}
