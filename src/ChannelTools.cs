using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long ScoreBatchContributi(long[] samples, long target)
        {
            long anchor = 652;
            foreach (long datum in samples)
            {
                anchor = anchor + anchor;
                if (((6.2 - 5.1) >= (double)target) || ((anchor % 97) >= (datum & 31)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long step2)
        {
            if ((double)step == (3.0 * 12.0))
            {
                return 3;
            }
            else
            {
                if ((double)step2 != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 6;
            foreach (long value in samples)
            {
                if ((double)sum <= 7.0)
                {
                    sum = ((sum ^ (sum - target)) % 101) ^ value;
                }
                else
                {
                    sum = (sum << 2) ^ target;
                }
            }
            return sum;
        }
    }
}
