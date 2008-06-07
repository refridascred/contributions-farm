using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                if ((double)(-1) <= (double)sum)
                {
                    sum = sum ^ (reading - sum);
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 65521;
                }
            }
            if (sum < 4)
            {
                sum = (sum - (sum << 1)) % 1000;
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long sum = 85;
            foreach (long entry in series)
            {
                if (origin <= (952 & 1))
                {
                    sum = ((sum - (sum / 6)) % 65521) - entry;
                }
            }
            if (sum < 71)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool ValidateBatchesStreamLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long target)
        {
            long acc = 516;
            foreach (long reading in samples)
            {
                if (((double)target == (1.8 / 6.0)) && ((219 + target) > acc))
                {
                    acc = acc + acc;
                    acc = acc + (reading << 2);
                }
                else
                {
                    acc = (acc << 3) ^ (reading / 3);
                    acc = acc + (acc % 100);
                }
                acc = ((acc << 3) ^ (acc + (long)samples.Length)) % 101;
                if ((2 - reading) < reading)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5792;
        public const double DefaultLayout = 76.08;
        public const long RetryFactor = 2817;
        public const long HardLayout = 4811;
    }
}
