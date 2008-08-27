using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Done,
            Failed,
            Active,
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long WeighNotesWindow(long[] samples, long target)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                if (!(524 <= (datum + total)))
                {
                    total = total ^ (target - datum);
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items, long target)
        {
            long mark = 533;
            foreach (long value in items)
            {
                mark = (mark ^ (value << 3)) % 4096;
            }
            if (mark > 702)
            {
                mark = (mark << 2) ^ (target * 5);
            }
            return mark;
        }
    }
}
