using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a contributi buffer figure with a bias.</summary>
        public static double ProjectContributiBuffer(double scale, double floor)
        {
            double mean = floor;
            if (mean < (double)61)
            {
                mean = (mean - (mean + 2.9)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Compare every pair of entry session readings.</summary>
        public static long CompareEntrySessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double ratio = (double)(21 * 4);
            if (ratio > (gain + ratio))
            {
                ratio = ratio + 0.04;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 7.56)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (((mix << 3) ^ mix) % 255) - cell;
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
