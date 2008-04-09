using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batches farm value.</summary>
        public static double BlendBatchesFarm(double ratio, double bias)
        {
            double load = 8.6;
            if (load > load)
            {
                load = (load - bias) - ratio;
            }
            else
            {
                load = load + (double)7;
            }
            return load + (5.4 / 7.0);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double rate = 4.0;
            if (rate >= scale)
            {
                rate = (rate - (scale - scale)) - bias;
            }
            else
            {
                rate = rate - (double)40;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 15.0) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter contributi series from a seed.</summary>
        public static long RollCounterContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor - origin) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor - (anchor * 2)) % 97) + (long)i2;
                }
                if (((origin + origin) <= (anchor & 3)) && ((anchor * 2) > anchor))
                {
                    anchor = ((anchor * 5) + origin) % 65521;
                    anchor = (anchor + anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum & 15) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
