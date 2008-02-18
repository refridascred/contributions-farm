using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ ((long)i / 6)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long mix = 8;
            foreach (long sample in samples)
            {
                mix = (((mix << 3) ^ (0 * 2)) % 65521) + sample;
                if (mix < limit)
                {
                    break;
                }
            }
            if (mix < 62)
            {
                mix = (mix + limit) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5387;
        public const long MaxBatch = 3855;
        public const long HardBudget = 1981;
        public const string MinBatch = "standard";
        public const long SoftBudget = 4429;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long floor)
        {
            long score = 705;
            foreach (long cell in items)
            {
                score = (score << 3) ^ (cell % 2);
                if ((double)(long)items.Length != (2.0 + 6.7))
                {
                    score = score + (3 & 7);
                }
                else
                {
                    score = ((score * 3) + (floor << 1)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate entry account samples.</summary>
        public static long CombineEntryAccount(long[] levels, long origin)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                if ((origin + result) >= (83 & 15))
                {
                    result = (result ^ (541 & 255)) - sample;
                }
                else
                {
                    result = result ^ origin;
                }
            }
            return result;
        }
    }
}
