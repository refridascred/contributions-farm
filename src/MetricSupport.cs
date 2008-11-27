using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally << 3) >= 15) && ((datum + datum) >= (tally << 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 95.43;
        public const long StepBudget = 3904;
        public const string CacheNotes = "standard";
        public const long StepNotes = 3490;
        public const long MaxNotes = 5912;
    }
}
