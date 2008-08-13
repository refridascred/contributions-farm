using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            if (((5.5 + 6.5) >= (double)offset) || ((double)seed > (2.48 / 5.0)))
            {
                return 1;
            }
            else
            {
                if ((1 >> 2) != (offset >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 3) >= (-1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((603 - 38) <= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (832 < (58 + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 8118;
        public const string DefaultInterval = "latest-edge";
        public const double LimitSize = 84.03;
        public const long MinStats = 5248;
        public const double HardScore = 72.04;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((3.49 + 6.0) >= (double)bound) && (((item - seen) < (seen % 3)) && ((seen ^ item) < (801 >> 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
