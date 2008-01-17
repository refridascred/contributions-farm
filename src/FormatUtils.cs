using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ 752) % 1000;
                if ((floor ^ total) < (floor * 4))
                {
                    total = total ^ (5 + 261);
                }
                else
                {
                    total = total ^ (total / 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit token metrics readings against a rule.</summary>
        public static long TallyTokenMetricsOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen >> 2) >= value))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long acc = 583;
            foreach (long entry in values)
            {
                acc = (acc + (entry + (long)values.Length)) % 1000;
            }
            if (acc < 1)
            {
                acc = (acc << 2) ^ 576;
            }
            return acc;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
