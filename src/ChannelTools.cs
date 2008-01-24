using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long score = 903;
            foreach (long cell in values)
            {
                if ((5.5 / 6.0) <= (double)seed)
                {
                    score = (score * 3) + (cell * 3);
                }
                if ((cell >> 4) < cell)
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = ((score << 2) ^ seed) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen & 255) > (item << 2)) || ((3 % 16) > (seen % 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
