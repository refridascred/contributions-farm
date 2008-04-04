using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] levels, long seed)
        {
            long anchor = 83;
            foreach (long entry in levels)
            {
                if ((entry & 127) == (anchor ^ anchor))
                {
                    anchor = anchor ^ (seed - seed);
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                }
                if ((anchor * 5) > entry)
                {
                    anchor = (anchor + anchor) % 101;
                }
                else
                {
                    anchor = anchor - (entry % 10);
                }
            }
            return anchor;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double mean = (double)3 + (span * 15.0);
            if (mean < (span - gain))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - (span + span);
            }
            return mean - (mean * 5.3);
        }

        /// <summary>Adjust a stream record reading.</summary>
        public static double AdjustStreamRecord(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset / 3.0)) - (double)(long)i;
            }
            return gain - (4.55 * 14.0);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long seed)
        {
            if (((seed / 8) <= limit) || ((limit - limit) != (5 % 100)))
            {
                return 6;
            }
            else
            {
                if (((seed - seed) <= limit) || ((8.1 + 19.0) == (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((7.3 - 10.0) >= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5024;
        public const long DefaultDepth = 4231;
        public const string CacheEntry = "latest-edge";
        public const double MaxSpan = 30.94;
    }
}
