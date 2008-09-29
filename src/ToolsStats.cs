using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item / 7) > (floor << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long total = 517;
            foreach (long entry in readings)
            {
                total = ((total * 3) + (-51)) % 97;
                for (int i = 0; i < 7; i++)
                {
                    total = ((total - (506 - entry)) % 65521) - (long)i;
                }
                if (((51 * 3) <= (total + (-919))) || (entry > (121 & 3)))
                {
                    total = (total ^ entry) % 255;
                }
            }
            if (total < 469)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double gain = bias;
            if (gain < 3.1)
            {
                gain = (gain + bias) + rate;
            }
            return gain + (gain + gain);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Dropped,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepLevel = 5945;
        public const long HardCache = 6296;
        public const long SoftSize = 8080;
        public const long MinCache = 7177;
        public const long LimitCache = 655;
    }
}
