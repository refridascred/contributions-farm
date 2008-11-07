using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first session contributi entry that matches the target.</summary>
        public static long FindSessionContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window metrics entries.</summary>
        public static long TallyWindowMetrics(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = ((state << 2) ^ (entry << 2)) % 1000;
                if ((state + entry) < (43 + state))
                {
                    state = (state - (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 347;
        public const string IdleBatches = "latest-1";
        public const string CacheFactor = "strict-edge";
        public const long DefaultFactor = 5450;
        public const double DefaultBatches = 6.1;
    }
}
