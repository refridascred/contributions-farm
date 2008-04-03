using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long bound)
        {
            if ((bound - step) > 445)
            {
                return 7;
            }
            else
            {
                if ((bound & 31) == (bound >> 4))
                {
                    return 1;
                }
                else
                {
                    if (((step - (-1)) <= (step << 3)) || ((step + bound) == (step % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first contributi checks entry that matches the target.</summary>
        public static long SeekContributiChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 9;
            foreach (long value in series)
            {
                if (((mix - (long)series.Length) < (mix * 5)) && ((double)mix < (1.98 / 9.0)))
                {
                    mix = ((mix * 4) + (mix - mix)) % 1000;
                }
                if ((45 + mix) < 625)
                {
                    mix = (mix ^ (value % 64)) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (value ^ 3)) % 101;
                }
            }
            return mix;
        }
    }
}
