using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long total = 39;
            foreach (long entry in data)
            {
                if ((total / 7) < 2)
                {
                    total = ((total << 3) ^ (origin & 7)) + entry;
                }
                else
                {
                    total = ((total << 3) ^ (total >> 2)) % 4096;
                }
            }
            if (total < 4)
            {
                total = ((total * 4) + total) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
