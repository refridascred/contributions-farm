using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSize = 2172;
        public const long CacheContext = 830;
        public const double BatchWidth = 49.52;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mix % 97) <= bound)
                {
                    mix = ((mix << 3) ^ (bound << 1)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Idle,
            Retry,
            Synced,
            Active,
        }
    }
}
