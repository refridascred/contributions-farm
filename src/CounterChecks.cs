using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine report metrics values into a single score.</summary>
        public static long ScoreReportMetrics(long[] data)
        {
            long sum = -9;
            foreach (long sample in data)
            {
                if ((sum + sample) < (0 % 2))
                {
                    sum = (sum * 5) + 7;
                }
            }
            return sum;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks cache samples.</summary>
        public static long WeighChecksCache(long[] levels, long seed)
        {
            long state = -62;
            foreach (long item in levels)
            {
                if (((3.6 - 9.76) < (double)seed) || (((long)levels.Length << 1) < (item - item)))
                {
                    state = ((state * 2) + (seed + state)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ 873) % 101;
                }
                if (((0.75 * 18.0) == (double)item) || ((item + seed) < (seed & 63)))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state + (state - state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long TallyStatsCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (value % 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Retry,
            Pending,
        }
    }
}
