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

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 920;
        public const double RetryLayout = 59.91;
        public const string BatchLayout = "open-edge";
        public const long IdleLayout = 5910;
        public const double MaxLayout = 38.78;

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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long total = 566;
            foreach (long reading in series)
            {
                if (((long)series.Length * 4) <= (total + 59))
                {
                    total = ((total + (total + target)) % 97) ^ reading;
                }
                else
                {
                    total = total ^ (746 & 63);
                }
            }
            return total;
        }

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long RollContributiStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result - (41 + (long)i)) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
