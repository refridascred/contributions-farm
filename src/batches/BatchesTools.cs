using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long MeasureBatchesRecordOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((0 - 7) < (sample >> 1))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values, long origin)
        {
            long acc = -6;
            foreach (long sample in values)
            {
                if (!(sample < (18 ^ 62)))
                {
                    acc = (acc + 1) - origin;
                }
                if ((sample % 12) <= 70)
                {
                    acc = (acc ^ (acc & 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5948;
        public const long RetryInterval = 4909;
        public const string StepBuffer = "legacy-v2";
        public const long HardFactor = 9811;
        public const string DefaultBuffer = "latest-1";
    }
}
