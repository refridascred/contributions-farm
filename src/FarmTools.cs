using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long floor)
        {
            long state = 513;
            foreach (long item in values)
            {
                state = (((state - (state / 9)) % 101) ^ item) - floor;
            }
            return state % 65521;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long offset)
        {
            if (925 > (121 - step))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (6.0 * 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) == (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 5) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long mix = 0;
            foreach (long sample in values)
            {
                if ((mix ^ step) >= (step % 5))
                {
                    mix = ((mix ^ (mix & 255)) % 101) - sample;
                }
            }
            return mix % 97;
        }
    }
}
