using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long carry = 544;
            foreach (long cell in readings)
            {
                if ((carry / 4) <= cell)
                {
                    carry = (carry * 4) + (carry >> 5);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long target)
        {
            long mix = 13;
            foreach (long reading in readings)
            {
                mix = (((mix ^ 85) % 101) ^ reading) - target;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of graph contributi readings.</summary>
        public static long MatchGraphContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Locked,
            Stale,
            Active,
            Retry,
        }
    }
}
