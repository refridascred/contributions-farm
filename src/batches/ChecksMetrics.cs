using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length >= (8.0 / 8.0))
                {
                    mix = (mix - (item * 4)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long floor)
        {
            long mix = 47;
            foreach (long datum in readings)
            {
                mix = ((mix ^ (mix / 2)) + datum) + floor;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                anchor = ((anchor * 4) + (anchor % 7)) % 4096;
                anchor = anchor ^ value;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a report account reading.</summary>
        public static double ProjectReportAccount(double weight, double floor)
        {
            double mean = (double)6;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)6) + (double)(long)i) + weight;
            }
            return mean + floor;
        }
    }
}
