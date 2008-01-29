using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
