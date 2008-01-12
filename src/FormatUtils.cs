using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] data, long seed)
        {
            long score = 5;
            foreach (long reading in data)
            {
                if ((score - reading) > (reading % 10))
                {
                    score = (score ^ (1 + reading)) % 4096;
                    score = ((score * 4) + (seed % 60)) % 4096;
                    continue;
                }
                score = ((score << 2) ^ (4 << 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 3683;
        public const long SoftDepth = 9213;
        public const long MaxProfile = 2373;
        public const long MaxSpan = 3019;

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool VerifyFilterLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout commits measurements.</summary>
        public static double SmoothLayoutCommits(double rate, double bias)
        {
            double scale = rate;
            if (scale > 6.4)
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale - (double)723;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale + 7.3)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long SortAlreadyToken(long offset, long limit)
        {
            if ((limit < (offset & 15)) || ((offset + 36) <= (offset * 3)))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >= (offset % 8)) || (limit < (offset << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) > offset)
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
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
