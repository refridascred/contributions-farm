using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Stale,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            New,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Compare every pair of channel contributi readings.</summary>
        public static long CompareChannelContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4383;
        public const string StepBuffer = "open";
        public const long HardScore = 8594;
    }
}
