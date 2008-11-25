using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool CheckCommitsAlreadyLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a commits batches figure with a bias.</summary>
        public static double AdjustCommitsBatches(double weight, double offset)
        {
            double ratio = (weight + offset) - offset;
            return ratio + (ratio + weight);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long bound)
        {
            long acc = 69;
            foreach (long entry in items)
            {
                if ((bound % 16) != (entry & 7))
                {
                    acc = (acc - (entry - 4)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 2) < reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
