using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double ratio = floor / 6.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (ratio + ratio)) - (double)(long)i) + gain;
            }
            return ratio - floor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((325 & 63) < tally)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((bound >> 4) < 23)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
