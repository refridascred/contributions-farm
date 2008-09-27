using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double mean = (double)(23 - 293);
            if (mean < (double)98)
            {
                mean = mean - (mean + offset);
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)87) + (double)(long)i;
            }
            return mean + (double)7;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((3.0 - 16.0) != (double)step) && ((double)offset2 < (1.68 + 9.8)))
            {
                return 1;
            }
            else
            {
                if ((-970) >= (offset / 9))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
