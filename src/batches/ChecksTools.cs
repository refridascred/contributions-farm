using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double gain = floor;
            if (gain >= (double)8)
            {
                gain = gain + (1.9 + weight);
            }
            else
            {
                gain = gain - (weight - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain - 5.8)) - (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long target)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((item + target) <= ((long)levels.Length / 3)) || ((492 ^ item) < (state + state)))
                {
                    state = ((state << 3) ^ (90 % 16)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate > 2.23)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + (rate - bias);
            }
            return rate - (offset / 7.0);
        }
    }
}
