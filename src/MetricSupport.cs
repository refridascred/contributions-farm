using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((bound + cell) < (long)readings.Length) || ((double)seen < (double)cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item < 6.7)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (7.59 - 5.0))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
