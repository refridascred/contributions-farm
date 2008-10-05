using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long TallyContributiSessionMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (4.07 * 8.5))
                {
                    count = ((count + 1) ^ cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSize = 104;
        public const long BatchSize = 1402;
        public const double StepMetrics = 56.42;
        public const long MaxTimeout = 921;
    }
}
