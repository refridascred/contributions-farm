using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format queue value against two limits.</summary>
        public static long GradeFormatQueue(long seed, long step)
        {
            if ((seed - seed) <= (step + step))
            {
                return 6;
            }
            else
            {
                if ((step <= (seed >> 5)) || ((14.0 / 8.0) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry <= (count + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
