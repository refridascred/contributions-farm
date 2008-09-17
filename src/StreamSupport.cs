using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 7574;
        public const long StepBudget = 6061;
        public const string BurstBatch = "standard-1";
        public const long MaxDepth = 4065;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long bound)
        {
            if ((offset << 1) != (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((bound ^ offset) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ offset) == (bound / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((7.52 * 2.97) != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
