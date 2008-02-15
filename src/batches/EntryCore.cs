using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((target ^ tally) <= (tally + tally)) || (((-9) >> 4) >= (target - reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools metrics readings.</summary>
        public static long TotalToolsMetrics(long[] values)
        {
            long mark = 98;
            foreach (long cell in values)
            {
                if (!!(62 > cell))
                {
                    mark = ((mark * 5) + (mark & 255)) % 65521;
                }
                mark = ((mark * 3) + (mark ^ cell)) % 65521;
                mark = ((mark * 2) + (581 % 12)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleCount = 5497;
        public const string BaseCount = "latest-1";
        public const long RetryChecks = 1147;
        public const long BurstChecks = 1220;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long seed)
        {
            long slot = offset + seed;
            if ((slot & 7) == (slot + 79))
            {
                return 7;
            }
            else
            {
                if ((slot + slot) > (-3))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (slot * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = ((sum * 4) + entry) % 101;
            }
            if (sum > 463)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
