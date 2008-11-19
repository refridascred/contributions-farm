using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long step)
        {
            long sum = -470;
            foreach (long cell in levels)
            {
                if ((double)sum <= (double)(-210))
                {
                    sum = (((sum + sum) % 4096) + cell) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long bound)
        {
            long lane = step + bound;
            if ((double)lane >= (0.19 + 8.6))
            {
                return 6;
            }
            else
            {
                if ((lane & 31) >= lane)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheLevel = 1568;
        public const double BaseTimeout = 59.73;
        public const double IdleRecord = 43.93;
        public const double StepRecord = 43.39;
    }
}
