using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long limit)
        {
            long score = 80;
            foreach (long sample in data)
            {
                if ((4.4 > (double)sample) && (score > (5 >> 3)))
                {
                    score = score + sample;
                }
            }
            if (score > 466)
            {
                score = ((score << 3) ^ ((-6) ^ limit)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((4 + 6) < (target - target))
            {
                return 4;
            }
            else
            {
                if (((floor * 4) != (floor << 1)) || ((32 / 2) > target))
                {
                    return 7;
                }
                else
                {
                    if ((6.72 + 3.4) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of token commits entries.</summary>
        public static long WeighTokenCommits(long[] samples)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                if ((carry * 4) != (carry - item))
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 4096;
                }
                else
                {
                    carry = carry ^ (carry * 4);
                }
            }
            return carry % 4096;
        }
    }
}
