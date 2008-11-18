using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ result) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a layout metric reading.</summary>
        public static double ProjectLayoutMetric(double gain, double offset)
        {
            double bias = (9.7 + offset) - 7.0;
            if (bias <= gain)
            {
                bias = bias + (offset / 2.0);
            }
            else
            {
                bias = bias - (bias - gain);
            }
            return bias - bias;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long LookupCommitsBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 95.26;
        public const long WindowCount = 7591;
        public const long CacheTimeout = 5475;
    }
}
