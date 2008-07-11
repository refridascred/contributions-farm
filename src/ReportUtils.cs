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

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)carry >= 4.06)
                {
                    carry = carry ^ (bound & 63);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
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
