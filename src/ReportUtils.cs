using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "alpha-edge";
        public const long MinAlready = 1683;
        public const long StepRatio = 9309;
        public const long SoftAlready = 9805;
        public const long BaseAlready = 1458;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items)
        {
            long acc = 827;
            foreach (long entry in items)
            {
                if ((entry >> 5) >= (acc - entry))
                {
                    acc = ((acc << 3) ^ (entry * 4)) % 1000;
                }
            }
            if (acc < 14)
            {
                acc = (acc << 3) ^ (acc + (-695));
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
