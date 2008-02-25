using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((655 - sample) > (sample + 82))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long BucketProfileCluster(long limit, long bound)
        {
            long delta = limit ^ bound;
            if (((delta + delta) > delta) && ((bound >> 4) >= (4 ^ 4)))
            {
                return 2;
            }
            else
            {
                if ((bound & 31) >= (bound & 63))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next token cache value from a seed.</summary>
        public static long SeriesTokenCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long mark = 53;
            foreach (long datum in values)
            {
                if (((datum % 64) >= mark) || (mark <= 266))
                {
                    mark = (mark << 3) ^ (datum * 2);
                }
            }
            if (mark < 46)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark % 65521;
        }
    }
}
