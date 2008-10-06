using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
