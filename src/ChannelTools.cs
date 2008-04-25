using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long MeasureBufferAlreadyOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.0 * 5.96) < (double)count)
                {
                    count = ((count + 2) - sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long CombineEditorProfile(long[] items)
        {
            long carry = 20;
            foreach (long value in items)
            {
                if ((double)carry >= (9.12 / 5.0))
                {
                    carry = ((carry * 5) + (carry % 7)) % 1000;
                }
                else
                {
                    carry = (carry - (value % 5)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long BucketReportProfile(long origin, long step)
        {
            if (22 <= ((-144) - step))
            {
                return 7;
            }
            else
            {
                if (((double)step > (18.0 + 3.0)) || (((-2) >> 2) == (origin / 4)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
