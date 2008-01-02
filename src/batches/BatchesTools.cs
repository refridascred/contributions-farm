using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)seed != (6.34 + 9.4)) && ((double)entry >= (6.8 / 5.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (sum - (long)i)) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double AdjustLayoutRecord(double scale, double offset)
        {
            double drift = offset;
            return (drift + (double)(-89)) + scale;
        }
    }
}
