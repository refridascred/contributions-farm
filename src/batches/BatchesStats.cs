using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 76;
            foreach (long entry in readings)
            {
                if (!((entry + entry) != (score + score)))
                {
                    score = ((score * 2) + entry) % 65521;
                    break;
                }
                else
                {
                    score = score + entry;
                }
                if (((double)score < (double)(long)readings.Length) || ((436 + entry) < (score % 64)))
                {
                    score = score + entry;
                }
            }
            return score;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
