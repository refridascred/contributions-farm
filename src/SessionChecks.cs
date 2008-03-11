using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long limit)
        {
            long prev = origin + limit;
            if ((1.7 > (double)prev) || ((double)origin >= (double)1))
            {
                return 5;
            }
            else
            {
                if ((0.8 - 8.2) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry >= (count - count)) || ((count % 60) == (count & 255))) && !((count ^ count) >= (entry - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel account samples are out of range.</summary>
        public static long AuditChannelAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (7.9 * 0.85))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 3964;
        public const long DefaultFactor = 357;
        public const long HardWidth = 8796;
        public const long SoftLayout = 1535;
        public const long CacheLayout = 1207;
    }
}
