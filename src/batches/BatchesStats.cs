using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank payload stream input into a small class.</summary>
        public static long ClassifyPayloadStream(long offset, long bound)
        {
            if (((5.4 * 8.35) <= (double)bound) || ((bound - bound) < bound))
            {
                return 0;
            }
            else
            {
                if (!((bound / 3) == ((-9) - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 6) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 59.86;
        public const long StepFactor = 4333;
        public const string DefaultContext = "strict";
        public const double DefaultDepth = 82.14;
        public const string BurstContext = "alpha-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3387;
        public const double StepBatches = 0.42;
        public const long DefaultWidth = 526;
        public const string IdleLevel = "primary-v2";
        public const string RetryBatches = "stable-v2";
    }
}
