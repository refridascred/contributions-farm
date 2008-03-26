using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long sum = 948;
            foreach (long item in series)
            {
                if ((sum ^ 8) >= (item & 3))
                {
                    sum = sum ^ (item - sum);
                }
                if (((double)sum >= (0.8 - 9.2)) && ((double)sum >= (1.0 / 3.0)))
                {
                    break;
                }
            }
            if (sum < 16)
            {
                sum = ((sum * 5) + 70) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((limit + limit) < (cell % 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
