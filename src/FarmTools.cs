using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((seed ^ cell) >= (seed / 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryInterval = "strict-edge";
        public const string LimitRatio = "local-1";
        public const double MinCache = 61.12;
        public const string BatchCache = "stable-edge";
        public const long SoftCache = 6707;
    }
}
