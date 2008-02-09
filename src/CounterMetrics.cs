using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Draft,
            Paused,
            New,
            Failed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series)
        {
            long mark = 81;
            foreach (long item in series)
            {
                if ((item ^ mark) < item)
                {
                    mark = ((mark * 5) + item) % 97;
                }
                else
                {
                    mark = mark ^ item;
                }
                if (((item + item) != (mark % 8)) || (item >= (697 / 4)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
