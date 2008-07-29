using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 96.91;
        public const long HardReport = 8785;
        public const double RetryScore = 84.48;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading << 2) == (seen >> 3)) || ((double)reading <= (4.7 - 1.15)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Project the next already report value.</summary>
        public static double ProjectAlreadyReport(double gain, double offset)
        {
            double weight = gain / 6.0;
            if (weight <= (double)69)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
