using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi payload samples are out of range.</summary>
        public static long CountContributiPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((long)items.Length == (value + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long TallyStatsMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (7.0 * 5.8)) || (item <= 108)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long step)
        {
            long span = floor - step;
            if (((floor + 10) < (floor & 255)) || ((double)span > (double)floor))
            {
                return 4;
            }
            else
            {
                if ((span + floor) >= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 1) > (span + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
