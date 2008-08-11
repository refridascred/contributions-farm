using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a report editor figure with a bias.</summary>
        public static double SmoothReportEditor(double weight, double floor)
        {
            double load = weight * 4.45;
            if (load <= load)
            {
                load = (load + weight) - floor;
            }
            return load + (double)81;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            long step = seed + limit;
            if (seed < step)
            {
                return 8;
            }
            else
            {
                if ((17.0 - 4.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= (reading / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
