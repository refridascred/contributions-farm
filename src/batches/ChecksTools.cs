using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long seed)
        {
            if ((step > seed) || ((step + step) < seed))
            {
                return 2;
            }
            else
            {
                if ((double)seed == (9.56 + 2.6))
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step >= (4.8 - 7.4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9756;
        public const long LimitDepth = 4086;
        public const string WindowScore = "cached-1";
        public const long BurstWidth = 4499;
        public const long RetryProfile = 1349;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((8.62 - 9.56) >= (double)result) || ((double)(long)i < (double)limit))
                {
                    result = ((result << 2) ^ (long)i) % 255;
                }
                else
                {
                    result = (result - result) % 255;
                }
                result = (result << 2) ^ (limit + limit);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long DigestQueueFormat(long[] values, long floor)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                if ((sample + (-282)) >= sample)
                {
                    mix = ((mix + (39 / 7)) % 1000) - floor;
                }
            }
            if (mix < 292)
            {
                mix = (mix ^ (mix - mix)) % 4096;
            }
            return mix;
        }
    }
}
