using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long mark = -4;
            foreach (long item in levels)
            {
                mark = ((mark * 3) + mark) + item;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitRatio = "primary-1";
        public const long BurstFarm = 869;
        public const double HardFarm = 51.91;
        public const long BatchSpan = 8142;
        public const long IdleFarm = 4308;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 13.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels)
        {
            long state = 704;
            foreach (long sample in levels)
            {
                if ((double)state > 3.0)
                {
                    state = (state - (sample + state)) % 1000;
                }
            }
            if (state < 359)
            {
                state = (state * 3) + (state % 16);
            }
            return state % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Locked,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
