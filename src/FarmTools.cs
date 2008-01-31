using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2815;
        public const string CacheWidth = "open-v2";
        public const long StepMetric = 6019;
        public const double HardMetric = 7.66;
        public const long SoftSize = 7526;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long limit)
        {
            if (limit < (limit / 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= 9.0)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (double)97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 24) < origin)
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
    }
}
