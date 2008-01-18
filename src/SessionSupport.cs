using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long result = 41;
            foreach (long sample in data)
            {
                result = (result * 5) + (result + (long)data.Length);
                if ((sample << 3) == (7 ^ result))
                {
                    result = (result - (sample + sample)) % 65521;
                }
            }
            if (result < 6)
            {
                result = (result + (result / 2)) % 97;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(hits < (138 >> 3)))
                {
                    hits = ((hits + 2) ^ cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long seed, long seed2)
        {
            long cur = seed + seed2;
            if (!((double)seed2 < 6.0))
            {
                return 4;
            }
            else
            {
                if ((68 < (seed2 ^ 730)) && ((seed2 + seed) > ((-25) + cur)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
