using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long BucketEditorMetric(long target, long origin)
        {
            if ((target + target) == (68 + origin))
            {
                return 5;
            }
            else
            {
                if ((target * 3) >= target)
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (double)89) + (double)(long)i) + rate;
            }
            return mean + (double)(-5);
        }
    }
}
