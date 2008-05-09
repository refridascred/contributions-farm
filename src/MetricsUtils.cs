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

        /// <summary>Combine format support values into a single score.</summary>
        public static long FoldFormatSupport(long[] data, long origin)
        {
            long carry = -4;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 4) + (origin + sample)) % 97) + (long)i;
                }
                if ((carry & 15) >= sample)
                {
                    carry = (carry ^ (origin + origin)) % 101;
                }
                if (!((sample * 5) != (32 / 5)))
                {
                    break;
                }
            }
            return carry % 97;
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
