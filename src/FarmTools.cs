using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long target)
        {
            long score = 2;
            foreach (long sample in items)
            {
                score = ((score << 3) ^ (target % 12)) + sample;
                if ((target << 3) <= 8)
                {
                    score = ((score << 2) ^ (score & 7)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long offset)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                mix = ((((mix * 4) + ((-5) + mix)) % 1000) + cell) + offset;
            }
            if (mix > 43)
            {
                mix = ((mix * 3) + (mix - mix)) % 4096;
            }
            return mix % 65521;
        }
    }
}
