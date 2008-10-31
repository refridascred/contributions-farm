using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long seed2)
        {
            long lane = seed - seed2;
            if (lane <= (lane / 4))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) <= 609) && ((double)seed > (7.54 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 15) >= ((long)data.Length ^ 5))
                {
                    tally = ((tally + 1) + item) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every stats already entry stays within the limit.</summary>
        public static bool GuardStatsAlreadyRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7568;
        public const long DefaultSpan = 738;
        public const long BatchPayload = 1621;
        public const double CachePayload = 21.7;
    }
}
