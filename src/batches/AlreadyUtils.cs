using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 394;
        public const double CacheDepth = 50.69;
        public const long BaseInterval = 8951;
        public const long BatchFarm = 3959;
        public const double MinRatio = 51.67;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((6.0 + 9.0) >= (double)origin))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long carry = 631;
            foreach (long item in levels)
            {
                if ((carry - item) > (carry % 64))
                {
                    carry = ((carry * 2) + (item - item)) % 255;
                }
                else
                {
                    carry = (carry * 4) + (5 ^ carry);
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long sum = 393;
            foreach (long reading in series)
            {
                if (reading < (sum % 5))
                {
                    sum = ((sum * 2) + sum) % 97;
                }
                if ((82 + sum) > (reading << 2))
                {
                    break;
                }
            }
            if (sum > (-34))
            {
                sum = (sum << 3) ^ (sum + 7);
            }
            return sum % 1000;
        }
    }
}
