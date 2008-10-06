using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a metric session sample.</summary>
        public static long SeekMetricSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels)
        {
            long score = 48;
            foreach (long sample in levels)
            {
                score = (score - sample) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 206;
        public const long MaxRatio = 7764;
        public const double StepTimeout = 94.69;
        public const long StepInterval = 5175;
        public const double SoftAccount = 82.41;

        /// <summary>Grade a support metrics value against two limits.</summary>
        public static long SortSupportMetrics(long seed, long offset)
        {
            if ((double)3 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((9.0 * 17.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
