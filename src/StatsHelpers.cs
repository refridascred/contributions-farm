using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double ratio = (double)((-1) - 77);
            if (ratio >= floor)
            {
                ratio = ratio + (ratio / 2.0);
            }
            return ratio + (weight - floor);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((152 ^ hits) >= cell) && ((double)cell != (19.0 + 6.98))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((341 - count) <= 10)
                {
                    count = ((count + 2) - value) - bound;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "fallback-v2";
        public const string MaxPayload = "strict-edge";
        public const long StepPayload = 4489;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
