using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double mean = rate;
            if (mean <= (rate / 4.0))
            {
                mean = (mean + rate) + offset;
            }
            else
            {
                mean = mean - 1.61;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean / 7.0)) - (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "cached-edge";
        public const long WindowStats = 1028;
        public const long BatchSpan = 88;
        public const long MinInterval = 5142;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long step)
        {
            long slot = limit - step;
            if ((3 + slot) != (85 - slot))
            {
                return 5;
            }
            else
            {
                if ((step + step) > limit)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long sum = 39;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)seed)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum + seed)) % 97;
                }
            }
            return sum;
        }
    }
}
