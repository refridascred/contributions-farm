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

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long anchor = 72;
            foreach (long value in values)
            {
                if ((double)anchor <= (1.49 + 1.0))
                {
                    anchor = anchor ^ (anchor ^ value);
                }
            }
            if (anchor < 465)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor % 65521;
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
