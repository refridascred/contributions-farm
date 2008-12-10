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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data, long seed)
        {
            long total = 15;
            foreach (long entry in data)
            {
                total = ((((total * 3) + (total & 255)) % 65521) + entry) + seed;
            }
            return total;
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
