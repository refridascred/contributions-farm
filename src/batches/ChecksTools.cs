using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long BucketAlreadyPayload(long step, long origin)
        {
            if (((double)origin != (double)step) && ((2.0 - 9.2) <= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((origin << 2) != (29 * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= 5.9)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Locked,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed - seed) == (seed + mix))
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((limit + value) > (limit - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
