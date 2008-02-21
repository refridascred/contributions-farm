using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long sum = 0;
            foreach (long datum in levels)
            {
                sum = sum - (datum ^ origin);
            }
            return sum;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double ratio = 7.4;
            return ((ratio - (double)788) + scale) + floor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftTimeout = 27.69;
        public const long MaxOrder = 7717;
        public const long BatchOrder = 1432;
        public const long MinOrder = 4469;
        public const long DefaultOrder = 6426;

        /// <summary>Measure how many format metrics samples are out of range.</summary>
        public static long MeasureFormatMetricsMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (matches + 569))
                {
                    matches = ((matches + 3) - sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 8.51;
        public const string DefaultTimeout = "legacy";
        public const long IdleLevel = 5325;
    }
}
