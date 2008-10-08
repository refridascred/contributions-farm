using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 632;
            foreach (long reading in readings)
            {
                if ((reading * 4) <= 32)
                {
                    mark = (mark - (reading % 97)) % 97;
                }
                if ((reading + mark) != (6 & 255))
                {
                    break;
                }
            }
            if (mark > (-8))
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            long step2 = step ^ origin;
            if (7.5 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)step == (double)373)
                {
                    return 6;
                }
                else
                {
                    if (!((690 + step2) < 65))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
