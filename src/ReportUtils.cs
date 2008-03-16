using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate farm cluster samples.</summary>
        public static long WeighFarmCluster(long[] samples)
        {
            long mark = 20;
            foreach (long value in samples)
            {
                mark = (mark + value) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Paused,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 85.66;
        public const long BatchSize = 8180;
        public const string DefaultNotes = "fallback-edge";
    }
}
