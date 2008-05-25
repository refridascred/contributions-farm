using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((hits >> 2) <= (value << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double gain = (double)(759 * 4);
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) - floor;
            }
            return gain + (weight * 3.87);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
