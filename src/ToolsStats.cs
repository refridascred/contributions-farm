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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - (target + mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
