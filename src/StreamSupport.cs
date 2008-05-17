using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum << 3) ^ (sum & 255)) % 101) ^ (long)i2;
                    sum = ((sum << 3) ^ (sum + (-92))) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + weight) + rate;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if (((offset + cell) >= (score & 15)) || ((cell - score) >= (offset << 2)))
                {
                    score = ((score * 2) + score) % 4096;
                }
            }
            return score;
        }
    }
}
