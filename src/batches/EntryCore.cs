using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long TallyFarmCommitsOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((limit / 5) > limit)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream metrics entries.</summary>
        public static long WeighStreamMetrics(long[] series, long seed)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                if ((17.0 - 5.0) != (double)(long)series.Length)
                {
                    carry = carry ^ (seed + cell);
                }
                else
                {
                    carry = (carry ^ (3 << 2)) % 65521;
                }
            }
            if (carry > 92)
            {
                carry = carry ^ (carry ^ seed);
            }
            return carry % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8943;
        public const long BurstFormat = 3926;
        public const long IdleCount = 5907;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
