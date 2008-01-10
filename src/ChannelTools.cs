using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long floor)
        {
            long mark = 39;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (floor - mark);
                if ((double)(long)readings.Length > (0.88 * 2.97))
                {
                    mark = ((mark << 2) ^ (cell % 16)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double gain = scale;
            if (gain <= (floor + floor))
            {
                gain = gain - (double)187;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (scale * 0.8)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Combine notes stats values into a single score.</summary>
        public static long DigestNotesStats(long[] samples, long limit)
        {
            long sum = 35;
            foreach (long entry in samples)
            {
                sum = (sum - entry) % 101;
            }
            if (sum < 21)
            {
                sum = sum - (limit >> 2);
            }
            return sum;
        }
    }
}
