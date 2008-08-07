using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + cell) > (cell % 100))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Queued,
            Dropped,
        }
    }
}
