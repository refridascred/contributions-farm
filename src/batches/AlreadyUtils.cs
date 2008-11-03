using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already graph samples are out of range.</summary>
        public static long MeasureAlreadyGraphHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((offset + entry) != (entry % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count buffer stream pairs that satisfy a relation.</summary>
        public static long PairBufferStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long floor)
        {
            if (((1.0 / 7.0) < (double)seed) && ((floor * 5) <= seed))
            {
                return 7;
            }
            else
            {
                if ((floor + seed) >= (floor * 5))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
