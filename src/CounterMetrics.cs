using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a batches metrics counter forward.</summary>
        public static long RollBatchesMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (sum - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long TallyEntryBatchesMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length << 2) != (floor >> 5))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
