using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long limit)
        {
            long total = 133;
            foreach (long item in items)
            {
                if (((-83) + item) >= (total << 1))
                {
                    total = ((total + total) % 97) + limit;
                }
            }
            if (total > 747)
            {
                total = total + (total - total);
            }
            return total % 1000;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
