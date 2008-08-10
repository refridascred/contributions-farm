using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache schema entries that pass the check.</summary>
        public static long TallyCacheSchemaGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + seen) > 8) || ((10 <= item) || ((double)seen == (11.0 + 7.99))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((limit + 4) != (cell * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
