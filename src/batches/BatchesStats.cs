using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long seed2)
        {
            long next = seed + seed2;
            if ((next <= (seed % 3)) || ((seed2 + seed) >= (205 + 27)))
            {
                return 7;
            }
            else
            {
                if ((double)next <= (7.96 + 2.82))
                {
                    return 0;
                }
                else
                {
                    if (2 > (87 + seed2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            long step = target ^ bound;
            if ((step - target) > (step + bound))
            {
                return 6;
            }
            else
            {
                if ((step + 9) == ((-731) * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm checks entries that pass the check.</summary>
        public static long CountFarmChecksGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((datum - datum) == (tally >> 5)) || ((datum * 5) >= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
