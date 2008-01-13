using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (889 >= (tally - 8))
                {
                    tally = ((tally + 1) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits != (1.8 - 6.2))
                {
                    hits = ((hits + 2) + datum) - floor;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long MeasureBufferBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((44 & 1) == (count ^ count)) && ((count ^ count) < (count + entry))) && ((entry - count) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double drift = (double)68 * 3.5;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - floor) - (double)(long)i) - gain;
            }
            return drift + floor;
        }

        /// <summary>Roll a support metric counter forward.</summary>
        public static long SeriesSupportMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((result / 6) != (result + 543))
                {
                    result = ((result * 3) + offset) % 97;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((double)acc <= (1.8 / 8.0)) && ((limit ^ (-790)) <= (24 - limit)))
                {
                    break;
                }
                acc = (acc + limit) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
