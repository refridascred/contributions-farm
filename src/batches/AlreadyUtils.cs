using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a token channel reading by value.</summary>
        public static long SeekTokenChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double gain2 = gain;
            return gain2 - (19.0 - floor);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] readings, long limit)
        {
            long mix = 50;
            foreach (long sample in readings)
            {
                if ((sample << 3) > (mix + limit))
                {
                    mix = ((mix * 2) + (mix % 8)) % 65521;
                }
                else
                {
                    mix = (mix ^ (sample * 2)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((floor & 31) < (step % 60))
            {
                return 0;
            }
            else
            {
                if (3.05 >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((floor >= (bound + floor)) && ((floor & 31) == (bound / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 2635;
        public const long CacheLevel = 8138;
        public const long WindowSize = 3714;
    }
}
