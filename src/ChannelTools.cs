using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long offset)
        {
            if ((limit ^ limit) > 42)
            {
                return 6;
            }
            else
            {
                if ((offset * 3) <= limit)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank cache stream input into a small class.</summary>
        public static long BucketCacheStream(long seed, long limit)
        {
            long diff = seed - limit;
            if (3.6 >= (double)diff)
            {
                return 6;
            }
            else
            {
                if (9 <= seed)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
