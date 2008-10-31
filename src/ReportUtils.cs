using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long TallyMetricSessionHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally > (18.0 - 9.62))
                {
                    tally = ((tally + 2) - cell) + offset;
                }
            }
            return tally;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (double)681)
            {
                rate = (rate + ratio) + offset;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate - rate)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading < (86 << 1)) || (((reading % 2) > (hits << 1)) && ((hits * 3) > reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record counter samples.</summary>
        public static long WeighRecordCounter(long[] data, long floor)
        {
            long total = 59;
            foreach (long item in data)
            {
                if ((double)total == (6.0 + 6.44))
                {
                    total = (total * 3) + item;
                    continue;
                }
                if ((double)floor == (8.0 + 8.9))
                {
                    total = (total + (item & 3)) % 101;
                }
            }
            return total;
        }
    }
}
