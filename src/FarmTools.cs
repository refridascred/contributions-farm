using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache batches samples.</summary>
        public static long CombineCacheBatches(long[] readings, long step)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (value + value)) % 97) + step;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of counter metrics readings.</summary>
        public static long OverlapCounterMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate support farm samples.</summary>
        public static long ScoreSupportFarm(long[] data)
        {
            long acc = -63;
            foreach (long entry in data)
            {
                acc = ((acc - 3) % 65521) ^ entry;
            }
            if (acc < 721)
            {
                acc = (acc + (acc << 3)) % 1000;
            }
            return acc;
        }
    }
}
