using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (27 >> 5)) % 255;
                if ((12.0 * 9.33) < (double)origin)
                {
                    result = result ^ (9 % 60);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next notes order value.</summary>
        public static double ProjectNotesOrder(double weight, double offset)
        {
            double mean = (weight * 6.0) + weight;
            if (mean < weight)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean - (offset / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - weight) - (double)(long)i;
            }
            return mean - (double)5;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor % 97) <= (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((17 % 16) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + target) <= (target ^ target))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
