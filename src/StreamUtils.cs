using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long origin, long offset)
        {
            if ((offset + offset) > (origin + 9))
            {
                return 6;
            }
            else
            {
                if (origin < (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + offset) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + ((long)i * 2)) % 4096;
                if ((floor + anchor) != (6 + floor))
                {
                    anchor = (anchor - (74 - (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-v2";
        public const long HardBudget = 3980;
        public const long MaxRatio = 404;
        public const long SoftScore = 2154;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                long span = (limit & 7) + (limit & 63);
                long slot = (acc + span) << 1;
                span = (span - (slot - limit)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }
    }
}
