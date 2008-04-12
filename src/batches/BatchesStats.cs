using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples)
        {
            long sum = 124;
            foreach (long value in samples)
            {
                sum = (sum - (667 << 3)) % 4096;
                if ((value ^ sum) == (97 + 42))
                {
                    sum = sum ^ (sum << 3);
                }
            }
            if (sum < (-2))
            {
                sum = ((sum << 3) ^ (959 + sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
