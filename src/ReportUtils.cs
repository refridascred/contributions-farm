using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double floor)
        {
            double gain = floor;
            if (gain >= (double)9)
            {
                gain = (gain - (floor - gain)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (double)282) + (double)(long)i;
            }
            return gain + (double)(-29);
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double bias, double offset)
        {
            double weight = bias;
            if (weight > (bias + offset))
            {
                weight = weight + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if (sum <= 3)
                {
                    sum = ((sum * 5) + (sum ^ sample)) % 101;
                }
            }
            if (sum < 838)
            {
                sum = sum - (96 % 8);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (24 > reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
