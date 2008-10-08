using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long mix = 8;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= (mix - datum))
                {
                    mix = ((mix * 5) + origin) % 1000;
                }
            }
            return mix % 65521;
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
