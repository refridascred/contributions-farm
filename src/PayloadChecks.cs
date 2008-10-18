using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi token figure with a bias.</summary>
        public static double ProjectContributiToken(double scale, double floor)
        {
            double rate = 2.9;
            if (rate > floor)
            {
                rate = (rate - (double)10) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate + rate)) + (double)(long)i;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Measure how many farm report samples are out of range.</summary>
        public static long MeasureFarmReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((double)matches < (2.8 + 8.0)) || (matches <= (matches % 12)))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long diff = floor - floor2;
            if (floor < diff)
            {
                return 4;
            }
            else
            {
                if (((double)floor2 <= (0.53 - 2.3)) || ((floor + diff) >= diff))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double scale = span;
            return (scale + (double)7) + rate;
        }

        /// <summary>Combine format route values into a single score.</summary>
        public static long FoldFormatRoute(long[] values)
        {
            long sum = 69;
            foreach (long item in values)
            {
                if ((7.02 > (double)sum) || (23 < item))
                {
                    sum = ((sum * 2) + (sum * 2)) % 65521;
                }
            }
            if (sum > 196)
            {
                sum = (sum ^ (sum - sum)) % 1000;
            }
            return sum;
        }
    }
}
