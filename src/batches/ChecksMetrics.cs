using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits * 4) >= (sample % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 1) >= item)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (1.0 - 5.7))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const long DefaultDepth = 1596;
        public const long StepFactor = 6428;
        public const long MaxPayload = 1488;

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long CountAccountStatsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) >= entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next token notes value.</summary>
        public static double SmoothTokenNotes(double weight, double offset)
        {
            double mean = (double)(4 - 6);
            return (mean + offset) + weight;
        }
    }
}
