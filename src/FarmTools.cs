using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseSpan = "primary-v2";
        public const long BurstBatches = 624;
        public const string MaxBatches = "stable-edge";

        /// <summary>Match up record metric samples.</summary>
        public static long OverlapRecordMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long TallyRecordOrderOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((325 - 1) > matches)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
            }
            return matches;
        }
    }
}
