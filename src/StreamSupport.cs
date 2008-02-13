using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double rate2 = (offset / 4.0) + 9.6;
            if (rate2 >= (double)9)
            {
                rate2 = rate2 + (offset + 3.47);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - offset) - (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long acc = 125;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < reading)
                {
                    acc = ((acc * 5) + (acc - acc)) % 255;
                }
                if (!((reading % 97) <= (3 >> 5)))
                {
                    acc = acc ^ (reading >> 5);
                }
                if ((acc >> 3) != (reading % 100))
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc;
        }
    }
}
