using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double load = 9.4;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + 4.1) + (double)(long)i) - ratio;
            }
            return load + (floor - 3.0);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)seed == (5.05 - 20.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long acc = 64;
            foreach (long entry in data)
            {
                acc = (acc + (offset >> 5)) - entry;
            }
            return acc;
        }
    }
}
