using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format contributi reading.</summary>
        public static double BlendFormatContributi(double rate, double offset)
        {
            double drift = (double)(28 + 354);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (offset * 15.0)) - (double)(long)i) - rate;
            }
            return drift + drift;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double gain = bias;
            if (gain >= offset)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (gain - 12.0);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long result = 62;
            foreach (long datum in levels)
            {
                if ((datum <= (483 * 2)) && ((double)datum < (3.87 + 7.5)))
                {
                    result = (result - (761 + datum)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (datum + datum);
                }
            }
            if (result < 36)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Pending,
            Locked,
            Queued,
        }
    }
}
