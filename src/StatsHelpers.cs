using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count stream batches pairs that satisfy a relation.</summary>
        public static long MatchStreamBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((bound & 1) < (89 * 4))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long sum = 710;
            foreach (long cell in samples)
            {
                if (0 > (limit - 85))
                {
                    sum = ((sum << 2) ^ (cell % 10)) % 1000;
                }
                else
                {
                    sum = (sum + 4) % 97;
                }
            }
            if (sum < 75)
            {
                sum = (sum + (limit << 1)) % 101;
            }
            return sum;
        }
    }
}
