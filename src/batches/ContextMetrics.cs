using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)8)
            {
                ratio = ratio - (gain - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (double)829) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((268 > (target - matches)) || (((long)values.Length & 63) > (695 - matches))))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine report commits values into a single score.</summary>
        public static long FoldReportCommits(long[] readings, long bound)
        {
            long total = 6;
            foreach (long sample in readings)
            {
                total = (total * 5) + (total << 1);
                if (6.2 < (double)sample)
                {
                    break;
                }
            }
            if (total < 32)
            {
                total = total ^ (bound << 1);
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits / 9) >= cell)
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally <= (entry - 23)) && (offset <= (offset + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
