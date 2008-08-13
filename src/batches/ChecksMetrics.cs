using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 89.46;
        public const string LimitTools = "latest";
        public const long MaxSize = 9013;
        public const long BaseTools = 4544;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWidth = 50.28;
        public const double IdleLevel = 94.76;
        public const long WindowScore = 9422;
        public const long MinInterval = 7124;
        public const string StepWidth = "open";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((9.89 - 4.17) != (double)(long)samples.Length) && (seen > (seen << 1)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue editor counter forward.</summary>
        public static long SeriesQueueEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((offset - score) > ((long)i * 5)))
                {
                    score = (score + (score >> 3)) % 4096;
                }
                score = (score - (score & 7)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
