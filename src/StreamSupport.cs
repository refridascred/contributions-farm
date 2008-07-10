using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double gain = floor;
            if (gain < (gain + 9.3))
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (scale / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (scale * 8.29)) + (double)(long)i;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((2.3 + 0.57) > (9.89 + 4.1))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long TallyEntryBufferHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample & 7) >= (count % 16))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
