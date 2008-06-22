using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((score + floor) < ((long)i << 1))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 7.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)28;
        }
    }
}
