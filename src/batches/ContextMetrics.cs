using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 6353;
        public const long BatchMetrics = 9547;
        public const long HardMetrics = 1361;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long AuditEntryFilterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits % 8))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string SoftCount = "latest-edge";
        public const string StepCount = "staging-edge";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Pending,
            Dropped,
            Queued,
        }
    }
}
