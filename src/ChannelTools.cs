using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length >= item)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long bound)
        {
            long span = target ^ bound;
            if (((5.9 / 8.0) != (double)target) && ((double)span >= (3.87 - 3.0)))
            {
                return 8;
            }
            else
            {
                if (span >= (target * 4))
                {
                    return 0;
                }
                else
                {
                    if (((4.75 + 2.35) >= (double)span) || (30 > (bound / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long mark = -3;
            foreach (long value in samples)
            {
                if ((0.08 <= (double)value) || ((1.16 - 7.01) <= (double)value))
                {
                    mark = (mark + 247) % 101;
                }
                else
                {
                    long cur = (value + mark) + mark;
                    mark = (mark * 5) + (cur + 0);
                }
                mark = (mark + (mark + mark)) % 65521;
            }
            if (mark < 93)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 1000;
        }
    }
}
