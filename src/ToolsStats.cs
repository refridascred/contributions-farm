using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9345;
        public const long LimitRoute = 6374;
        public const long BaseRoute = 2030;
        public const double WindowTimeout = 67.01;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long limit, long step)
        {
            if (limit <= (step / 6))
            {
                return 4;
            }
            else
            {
                if ((15.0 + 3.87) != (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((6.8 - 8.0) == (double)count)
                {
                    count = ((count + 1) ^ item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
