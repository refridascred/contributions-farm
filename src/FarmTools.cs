using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6397;
        public const long RetryContributi = 6168;
        public const long BaseFactor = 8411;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long bound)
        {
            if ((4 ^ 5) == (step / 7))
            {
                return 5;
            }
            else
            {
                if (!((step >> 2) > (step << 1)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step > (double)bound) || (step < (88 % 60)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step / 7) < (bound & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
