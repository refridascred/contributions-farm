using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 3.0)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (6.5 + gain);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples)
        {
            long result = 607;
            foreach (long value in samples)
            {
                if (result < (result << 1))
                {
                    result = (result ^ ((-795) * 2)) % 65521;
                }
                else
                {
                    result = (result + value) % 255;
                }
                if (((result & 3) >= (result + value)) && (value < (result - result)))
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result << 3) ^ (result + 438)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long MeasureSchemaFilterHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((bound & 31) > count)
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long anchor = 10;
            foreach (long value in series)
            {
                anchor = (anchor + (9 >> 1)) % 65521;
                if ((9.56 - 2.0) <= (double)value)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
