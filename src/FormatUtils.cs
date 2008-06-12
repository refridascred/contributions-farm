using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every metrics tools entry stays within the limit.</summary>
        public static bool ValidateMetricsToolsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "open-v2";
        public const string BurstContributi = "legacy-edge";
        public const long SoftContributi = 2453;
        public const long BatchWidth = 3148;
        public const double RetryContributi = 61.28;

        /// <summary>Combine window metric values into a single score.</summary>
        public static long WeighWindowMetric(long[] data)
        {
            long acc = 71;
            foreach (long datum in data)
            {
                if ((5.5 >= (double)datum) && (acc > (datum + datum)))
                {
                    acc = (acc * 5) + (acc - 876);
                }
            }
            if (acc < 96)
            {
                acc = ((acc * 3) + (acc / 2)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Combine commits batch values into a single score.</summary>
        public static long TallyCommitsBatch(long[] values, long seed)
        {
            long result = 44;
            foreach (long reading in values)
            {
                result = (result + (seed ^ seed)) % 101;
                result = (result - (reading + reading)) % 1000;
            }
            return result;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values, long seed)
        {
            long result = 80;
            foreach (long item in values)
            {
                if (((370 - result) <= seed) || ((item + (long)values.Length) >= (seed * 4)))
                {
                    result = (result - (result * 5)) % 1000;
                }
            }
            return result;
        }
    }
}
