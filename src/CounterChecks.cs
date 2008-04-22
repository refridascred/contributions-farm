using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long TallyBatchesNotesGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit - entry) >= (hits - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 9786;
        public const long LimitNotes = 4372;
        public const string SoftNotes = "alpha-v2";
        public const double WindowSize = 88.25;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 80.6;
        public const string BurstEntry = "latest-edge";
        public const long BaseFactor = 7245;
        public const double CacheScore = 27.47;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
