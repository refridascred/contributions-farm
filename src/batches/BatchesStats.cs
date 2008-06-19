using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 4504;
        public const string IdleGraph = "strict-v2";
        public const long StepInterval = 1620;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long seed, long bound)
        {
            if (!((bound >> 2) > (bound + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed % 7) > (seed + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long carry = 47;
            foreach (long entry in values)
            {
                if ((6 * 3) != (carry / 8))
                {
                    carry = ((carry * 4) + carry) % 255;
                }
                if ((carry - entry) == (0 + carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
