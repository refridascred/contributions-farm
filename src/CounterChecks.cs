using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Stale,
            New,
            Synced,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long CacheCounter = 9906;
        public const double BatchCounter = 20.32;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) > origin)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item / 2) < (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark ^ (mark & 1)) % 255;
                    mark = (mark << 3) ^ ((long)i2 & 255);
                }
                if ((long)i > (mark - mark))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
