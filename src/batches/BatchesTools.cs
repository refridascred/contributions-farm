using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit already metrics readings against a rule.</summary>
        public static long TallyAlreadyMetricsHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 4) == (135 >> 3))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 73.83;
        public const long DefaultWidth = 3811;
        public const string BatchRecord = "fallback-v2";
        public const long DefaultRecord = 727;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
