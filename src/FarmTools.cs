using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Synced,
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 980;
        public const double BatchCommand = 98.08;
        public const string MaxCommand = "local-v2";
        public const string BurstCommand = "local-v2";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) > bound)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
