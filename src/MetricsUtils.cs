using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((16.0 - 5.16) <= (double)entry) || ((count >= (entry >> 1)) && ((count >> 4) < (entry << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a commits order reading by value.</summary>
        public static long LookupCommitsOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8275;
        public const long BaseDepth = 5982;
        public const long BatchFormat = 94;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
