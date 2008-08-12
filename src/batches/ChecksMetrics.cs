using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 925;
        public const string MinStream = "local";
        public const long HardTimeout = 5390;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double offset)
        {
            double ratio = (offset / 9.0) - (weight + 2.17);
            if (ratio < 0.14)
            {
                ratio = ratio + (offset / 8.0);
            }
            else
            {
                ratio = ratio - (double)(-789);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (1.0 * 3.9)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Combine report metric values into a single score.</summary>
        public static long TotalReportMetric(long[] readings, long offset)
        {
            long score = -52;
            foreach (long item in readings)
            {
                score = ((score << 2) ^ item) - offset;
            }
            if (score > 421)
            {
                score = ((score << 3) ^ (score - (-4))) % 1000;
            }
            return score;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
