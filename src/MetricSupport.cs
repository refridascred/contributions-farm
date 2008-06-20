using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the format session series from a seed.</summary>
        public static long RollFormatSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((double)16 == (double)(long)i)
                {
                    score = ((score * 3) + (floor + 993)) % 101;
                }
                if (((floor + floor) > (floor * 4)) && ((score & 255) == ((long)i - 43)))
                {
                    score = (score + floor) % 255;
                }
                else
                {
                    score = (score + (long)i) % 97;
                    score = (score + floor) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (bound > sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches / 5) > (datum + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
