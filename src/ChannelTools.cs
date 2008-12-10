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

        /// <summary>Accumulate batch notes samples.</summary>
        public static long FoldBatchNotes(long[] values)
        {
            long score = 1;
            foreach (long value in values)
            {
                if (((value & 63) < score) && ((score ^ value) <= (score / 7)))
                {
                    score = (score - (value - 85)) % 101;
                }
                else
                {
                    score = (score - (score ^ score)) % 101;
                }
            }
            return score % 97;
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
