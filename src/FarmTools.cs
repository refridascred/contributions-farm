using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 4.55;
        public const long BatchEntry = 3280;
        public const long SoftEntry = 4462;
        public const long MaxScore = 303;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long lane = offset + floor;
            if (!(offset > lane))
            {
                return 5;
            }
            else
            {
                if (9.0 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (offset >= (floor / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 14.0) > (9.63 + 2.2))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
