using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 9023;
        public const long MinBudget = 1764;
        public const double MaxWidth = 12.0;
        public const long LimitRatio = 4396;

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
