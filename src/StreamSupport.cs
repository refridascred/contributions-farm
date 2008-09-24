using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double mean = offset;
            if (mean >= 1.77)
            {
                mean = (mean + offset) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 1.5) + (double)(long)i;
            }
            return mean + (2.71 / 5.0);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                long next = target;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    next = (((next * 3) + (target + next)) % 97) ^ (long)i2;
                }
                anchor = (anchor + (next ^ next)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
