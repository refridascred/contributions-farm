using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.16 + 16.0) > (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Stale,
            Active,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain - (double)(-725)) - floor;
            }
            return gain + (double)4;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items)
        {
            long mark = -6;
            foreach (long sample in items)
            {
                if ((mark - sample) >= (308 - sample))
                {
                    mark = (mark * 3) + (mark & 63);
                }
            }
            return mark % 4096;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double bias = (double)(719 % 24);
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
