using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long step)
        {
            if (!((limit << 3) <= (limit / 5)))
            {
                return 5;
            }
            else
            {
                if ((step + limit) == (step & 1))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long step, long bound)
        {
            long lane = step ^ bound;
            if (((double)lane == (9.0 * 16.0)) && (lane < bound))
            {
                return 7;
            }
            else
            {
                if (lane < (bound << 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 1378;
        public const double StepGraph = 88.74;
        public const long HardInterval = 9877;
        public const double HardGraph = 55.46;
        public const long StepRatio = 3510;
    }
}
