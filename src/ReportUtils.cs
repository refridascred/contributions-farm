using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool CheckNotesMetricBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen <= (0.7 - 7.3))
                {
                    seen = ((seen + 1) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((90 + offset) <= hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "standard";
        public const string MaxBuffer = "local-v2";
        public const long RetryTimeout = 7540;

        /// <summary>Grade a counter metric value against two limits.</summary>
        public static long ClassifyCounterMetric(long step, long origin)
        {
            if ((9.0 + 19.0) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if (6.9 >= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((step / 6) == (417 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + 960) != (step + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
