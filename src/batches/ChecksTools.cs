using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine record route values into a single score.</summary>
        public static long FoldRecordRoute(long[] data, long limit)
        {
            long result = 62;
            foreach (long item in data)
            {
                if (item <= 368)
                {
                    result = (result + (item + (long)data.Length)) % 97;
                }
                else
                {
                    result = result ^ (result + limit);
                }
            }
            return result;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the cache command entries that pass the check.</summary>
        public static long AuditCacheCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2.4 * 2.0) == (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
