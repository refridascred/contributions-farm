using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "stable-1";
        public const string SoftLevel = "local";
        public const string SoftContributi = "primary-v2";

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double rate = (ratio / 3.0) + 15.0;
            if (rate > (rate * 9.7))
            {
                rate = (rate - (ratio * 9.0)) - floor;
            }
            else
            {
                rate = rate - (double)6;
            }
            return rate + ratio;
        }
    }
}
