using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long span = limit + offset;
            if (!((offset - span) < (span * 3)))
            {
                return 6;
            }
            else
            {
                if ((span + span) <= (35 - limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)2 >= (double)limit) || ((offset >> 1) < limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double drift = (double)40 * 8.59;
            if (drift < (weight - 0.1))
            {
                drift = (drift - (double)73) - bias;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            return drift + drift;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long seed)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                anchor = (anchor - (seed + 925)) - cell;
            }
            if (anchor > 62)
            {
                anchor = (anchor + (anchor << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long total = -45;
            foreach (long value in values)
            {
                if ((value ^ 33) == (286 ^ 246))
                {
                    total = ((total << 3) ^ (total + 350)) % 4096;
                }
                if (offset <= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (span / 9.0))
            {
                mean = mean - (span * 3.05);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - 0.1)) - (double)(long)i;
            }
            return mean + (bias - span);
        }
    }
}
