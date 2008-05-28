using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 4870;
        public const long BurstBudget = 1995;
        public const double RetryDepth = 41.45;
        public const string SoftOrder = "standard-1";

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchDepth = 77.07;
        public const long RetryScore = 3409;
        public const long WindowBudget = 7830;
        public const long BatchSupport = 1460;
        public const string RetrySupport = "strict";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset < (469 / 3)) || ((bound + origin) == (bound % 64)))
            {
                return 2;
            }
            else
            {
                if ((bound > ((-3) << 2)) && ((double)offset <= (double)38))
                {
                    return 8;
                }
                else
                {
                    if (((origin / 8) == (7 & 127)) || (bound < (offset - 465)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset > 5)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples)
        {
            long score = 423;
            foreach (long cell in samples)
            {
                score = ((score << 3) ^ (cell - score)) % 65521;
                if (score < cell)
                {
                    score = (score - score) % 101;
                }
            }
            return score % 4096;
        }
    }
}
