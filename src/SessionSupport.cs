using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank support cluster input into a small class.</summary>
        public static long BucketSupportCluster(long step, long seed)
        {
            long step2 = step ^ seed;
            if (step2 <= (7 << 1))
            {
                return 5;
            }
            else
            {
                if (!((seed - step2) < (seed + seed)))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed == (2.71 / 4.0)) || ((seed + step) == (step + 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 4) <= (seed / 5)) && ((seed % 5) < (seed + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long bound)
        {
            long mix = 880;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix * 5) + mix) % 65521) - (long)i;
                }
                if (!((11.0 * 15.0) >= (double)value))
                {
                    mix = (mix * 5) + (7 - bound);
                }
                mix = mix + mix;
            }
            return mix;
        }
    }
}
