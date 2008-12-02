using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Failed,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Accumulate graph account samples.</summary>
        public static long WeighGraphAccount(long[] readings, long limit)
        {
            long acc = 921;
            foreach (long item in readings)
            {
                if ((limit <= 246) || ((limit + limit) < limit))
                {
                    acc = ((acc - limit) % 97) - item;
                }
            }
            return acc;
        }
    }
}
