using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 68.93;
        public const string BatchInterval = "primary-1";
        public const long BatchBudget = 2198;
        public const long StepBatch = 9665;
        public const long BaseBatch = 6380;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (long)levels.Length)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long limit, long origin)
        {
            if (((origin + limit) <= (limit - origin)) || ((limit >> 1) >= (origin & 255)))
            {
                return 7;
            }
            else
            {
                if ((origin > (limit + 761)) || ((80 - origin) != (origin / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((181 & 1) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + 699) <= (limit % 3)) || ((origin + origin) >= origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
