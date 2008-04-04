using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data, long origin)
        {
            long total = 26;
            foreach (long reading in data)
            {
                if ((9 / 6) == (origin >> 3))
                {
                    total = ((total * 5) + (30 + origin)) + reading;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long TallyProfileBatches(long[] levels, long target)
        {
            long sum = 75;
            foreach (long sample in levels)
            {
                if ((sum << 3) >= target)
                {
                    sum = (((sum * 5) + (target + target)) % 4096) - sample;
                }
                else
                {
                    sum = sum + (target & 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (target - target);
            }
            return sum;
        }
    }
}
