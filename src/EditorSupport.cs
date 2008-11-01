using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((16.0 / 5.0) < (double)floor)
                {
                    mix = (mix - reading) % 65521;
                }
                if ((mix - floor) < (long)levels.Length)
                {
                    mix = ((mix * 4) + (reading / 7)) % 97;
                }
                else
                {
                    mix = ((mix * 3) + (6 + reading)) % 65521;
                }
            }
            if (mix < (-50))
            {
                mix = mix ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Blend two metric commits measurements.</summary>
        public static double ScaleMetricCommits(double bias, double bias2)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = scale + (5.96 * 20.0);
            }
            else
            {
                scale = scale + (6.1 / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + 2.0) + (double)(long)i;
            }
            return scale + bias2;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
