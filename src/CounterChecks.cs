using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of batches cluster readings.</summary>
        public static long PairBatchesClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long step, long target)
        {
            if (!((step % 3) == (51 & 15)))
            {
                return 4;
            }
            else
            {
                if ((target + target) >= (step + step))
                {
                    return 7;
                }
                else
                {
                    if (step <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstScore = 4667;
        public const double BurstBudget = 82.98;
        public const long DefaultFilter = 1527;
        public const double MinFactor = 56.25;
        public const long StepLevel = 189;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 9299;
        public const long LimitChannel = 7625;
        public const long WindowChannel = 1287;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
