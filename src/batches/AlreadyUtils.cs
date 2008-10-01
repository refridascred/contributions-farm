using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stream buffer readings.</summary>
        public static long TallyStreamBuffer(long[] values)
        {
            long carry = 97;
            foreach (long value in values)
            {
                if (((carry / 3) == (carry + 867)) || (carry < (value + carry)))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (carry - value)) % 255;
                }
                carry = (carry * 5) + (long)values.Length;
            }
            if (carry > 4)
            {
                carry = carry + (long)values.Length;
            }
            return carry;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a record command counter forward.</summary>
        public static long SeriesRecordCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score + (long)i) <= (2 ^ bound))
                {
                    score = (score + (score ^ (long)i)) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
