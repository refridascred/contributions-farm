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

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9562;
        public const double MaxCommand = 89.16;
        public const double StepScore = 70.23;
        public const long LimitCommand = 3663;

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if (!((5 >> 2) >= (acc << 3)))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                }
                if (cell > (acc + cell))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((5.3 * 14.0) == (double)item)
                {
                    seen = seen + 2;
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
