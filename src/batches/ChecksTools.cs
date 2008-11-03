using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long offset, long origin)
        {
            long prev = offset - origin;
            if ((double)prev <= (13.0 + 15.0))
            {
                return 4;
            }
            else
            {
                if ((offset >= 189) || ((double)origin != (double)78))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5936;
        public const long MaxRatio = 5745;
        public const long BurstBatch = 6404;
        public const string MinRatio = "primary-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 98.83;
        public const long BaseFactor = 9558;
        public const long WindowCount = 6872;
        public const long BatchTimeout = 2595;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
