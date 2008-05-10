using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Count token contributi pairs that satisfy a relation.</summary>
        public static long PairTokenContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
