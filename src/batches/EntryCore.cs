using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstTimeout = 6166;
        public const long DefaultSupport = 8719;
        public const long RetrySupport = 5294;
        public const long HardSupport = 5799;
        public const long SoftRatio = 9897;

        /// <summary>Project the next batches route value.</summary>
        public static double ProjectBatchesRoute(double ratio, double floor)
        {
            double drift = (floor + floor) + floor;
            return (drift + drift) + ratio;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Count metric schema pairs that satisfy a relation.</summary>
        public static long PairMetricSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
