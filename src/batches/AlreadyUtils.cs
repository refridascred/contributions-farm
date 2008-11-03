using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] items, long step)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                if (!(cell > (257 >> 4)))
                {
                    mix = mix - step;
                }
            }
            return mix;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the commits metric series from a seed.</summary>
        public static long IterateCommitsMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels, long floor)
        {
            long sum = 390;
            foreach (long value in levels)
            {
                if (3.9 > (double)floor)
                {
                    sum = (sum + (sum - value)) % 65521;
                }
                if ((floor ^ sum) < (floor + sum))
                {
                    sum = (sum - (sum / 8)) % 4096;
                }
            }
            if (sum > 779)
            {
                sum = (sum + sum) % 65521;
            }
            return sum;
        }
    }
}
