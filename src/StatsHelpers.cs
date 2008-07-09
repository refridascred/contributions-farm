using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of editor cluster readings.</summary>
        public static long WeighEditorCluster(long[] values, long limit)
        {
            long result = 3;
            foreach (long value in values)
            {
                if (value < result)
                {
                    result = ((result * 3) + (result % 100)) % 65521;
                }
                else
                {
                    long seen = (limit - value) + (value - value);
                    result = result ^ seen;
                }
                result = (result + (369 >> 1)) % 97;
            }
            return result;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (anchor - (long)i)) % 101;
                anchor = ((anchor * 3) + (origin ^ 52)) % 255;
                if ((origin % 97) < anchor)
                {
                    anchor = (anchor + (origin / 4)) % 101;
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ origin) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) <= (offset + (long)values.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long CountCounterMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits == (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= (5 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
