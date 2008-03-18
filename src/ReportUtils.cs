using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const string BaseSpan = "staging-v2";
        public const long CacheTimeout = 5304;
        public const long RetryTimeout = 2170;

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long DigestSchemaCluster(long[] samples)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                carry = (carry - (reading - carry)) % 101;
            }
            if (carry < 719)
            {
                carry = carry - (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if ((origin + limit) >= origin)
            {
                return 5;
            }
            else
            {
                if ((632 + 488) > (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 3) <= 22) && ((limit ^ limit) == (limit % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((13.0 + 4.69) >= (double)origin) || ((6.94 / 6.0) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] series)
        {
            long mix = 850;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ datum) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
