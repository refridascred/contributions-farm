using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                if ((7 ^ sum) > (sum + sum))
                {
                    sum = sum + (entry * 3);
                }
            }
            return sum;
        }

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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
