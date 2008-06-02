using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long limit)
        {
            if (!((1.5 + 5.3) >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (5.5 - 8.1))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 2.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two session channel measurements.</summary>
        public static double ProjectSessionChannel(double scale, double offset)
        {
            double mean = (offset * 0.9) - (scale * 7.3);
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
