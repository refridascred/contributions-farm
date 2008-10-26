using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool VerifyEntryProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 60.44;
        public const double MaxScore = 90.03;
        public const string HardMetric = "legacy-v2";

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (7 + count))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
