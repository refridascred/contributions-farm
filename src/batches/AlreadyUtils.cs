using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double mean = 5.83;
            if (mean >= (double)761)
            {
                mean = (mean - (double)836) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean + 2.13)) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings, long target)
        {
            long result = 8;
            foreach (long item in readings)
            {
                if (!((result - target) == (0 << 1)))
                {
                    result = (result - (666 % 100)) - item;
                }
            }
            return result;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double load = floor;
            if (load < load)
            {
                load = (load + (load - load)) + ratio;
            }
            return load - (double)290;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - 9) % 4096;
                carry = (carry - 7) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
