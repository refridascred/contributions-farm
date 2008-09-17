using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 250;
        public const double BurstRoute = 84.11;
        public const long WindowDepth = 1171;
        public const long LimitRoute = 9274;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if (bound >= (bound >> 4))
            {
                return 5;
            }
            else
            {
                if ((3.4 / 6.0) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound / 2) == (8 + 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
