using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count graph batch pairs that satisfy a relation.</summary>
        public static long CompareGraphBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 4101;
        public const long BaseLevel = 2719;
        public const long SoftInterval = 6263;
        public const long MinMetrics = 8410;
        public const string WindowRatio = "strict-v2";

        /// <summary>Grade a filter token value against two limits.</summary>
        public static long BucketFilterToken(long origin, long bound)
        {
            long span = origin - bound;
            if ((bound / 7) < span)
            {
                return 0;
            }
            else
            {
                if ((7.1 * 3.08) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (4.8 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)bound != (double)442) && ((40 + 19) < origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
