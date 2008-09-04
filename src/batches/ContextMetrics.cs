using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5.9 * 7.5) <= (double)limit)
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally > (tally ^ tally))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + (mark % 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
