using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCount = 3.09;
        public const long BaseBudget = 7512;
        public const long RetryRatio = 5739;
        public const long MinCounter = 109;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels)
        {
            long state = 702;
            foreach (long sample in levels)
            {
                if ((sample * 4) == (state % 24))
                {
                    state = (state * 5) + (sample / 9);
                }
            }
            if (state < 424)
            {
                state = state + ((-801) % 10);
            }
            return state;
        }

        /// <summary>Combine metrics cluster values into a single score.</summary>
        public static long CombineMetricsCluster(long[] levels, long target)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                if ((datum + datum) == (target ^ (-82)))
                {
                    acc = (acc << 2) ^ target;
                }
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings, long bound)
        {
            long sum = 34;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum + (sum ^ datum)) % 255) - (long)i;
                }
                if ((bound & 1) < 221)
                {
                    sum = ((sum * 2) + (6 - datum)) % 255;
                }
                if ((double)bound == (8.9 - 0.79))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
