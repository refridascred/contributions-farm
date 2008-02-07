using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Done,
            Idle,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 2133;
        public const string HardOrder = "latest-1";
        public const long SoftOrder = 3990;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9114;
        public const string WindowInterval = "open-edge";
        public const long MinLevel = 314;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the queue order series from a seed.</summary>
        public static long IterateQueueOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
