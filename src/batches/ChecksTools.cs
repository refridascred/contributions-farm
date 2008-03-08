using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)bound >= (8.17 + 4.71))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Draft,
            Paused,
        }
    }
}
