using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Locked,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetrySpan = 67.78;
        public const long HardLayout = 1476;
        public const long MinLayout = 8798;
        public const string LimitLayout = "staging-1";
        public const long DefaultDepth = 6867;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 10) >= (datum + seen)) || (((seen * 3) <= 5) || ((seen & 63) > datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
