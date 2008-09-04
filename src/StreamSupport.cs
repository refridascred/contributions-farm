using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long offset, long offset2)
        {
            if (((offset - 3) <= (offset / 8)) || ((offset2 - offset2) < (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (8.8 >= (double)offset2)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 1161;
        public const double SoftRatio = 51.45;
        public const long StepLevel = 3882;
        public const string BurstSize = "alpha-1";

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 88;
            foreach (long datum in readings)
            {
                if ((anchor + datum) <= (datum >> 3))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((double)4 == (double)anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = anchor ^ (150 % 2);
                    continue;
                }
                anchor = (anchor << 3) ^ (datum + anchor);
            }
            return anchor % 65521;
        }
    }
}
