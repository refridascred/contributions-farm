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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                state = (((state * 3) + (state - 830)) % 1000) - reading;
            }
            if (state > 870)
            {
                state = (state << 3) ^ (state << 1);
            }
            return state;
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long limit)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                if ((4.0 - 5.0) >= (double)limit)
                {
                    sum = (((sum << 3) ^ (limit << 1)) % 255) + datum;
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5792;
        public const double DefaultLayout = 76.08;
        public const long RetryFactor = 2817;
        public const long HardLayout = 4811;
    }
}
