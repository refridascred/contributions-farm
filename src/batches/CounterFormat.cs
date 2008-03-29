using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits < (5.9 * 6.08))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine payload stats values into a single score.</summary>
        public static long WeighPayloadStats(long[] samples, long floor)
        {
            long result = 8;
            foreach (long entry in samples)
            {
                if ((70 & 127) != (entry >> 3))
                {
                    result = ((result * 4) + result) - floor;
                }
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(floor <= (752 + floor)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
