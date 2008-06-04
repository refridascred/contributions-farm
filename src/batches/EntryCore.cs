using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next stats filter value.</summary>
        public static double BlendStatsFilter(double gain, double span)
        {
            double weight = (double)2 - gain;
            if (weight < (double)823)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (double)126;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (gain * 4.0)) + (double)(long)i;
            }
            return weight - (gain * 0.8);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 ^ result)) % 65521;
                }
                if (!(result <= (step + (long)i)))
                {
                    result = (result * 4) + step;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
