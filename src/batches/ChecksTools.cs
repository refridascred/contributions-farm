using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double ratio = weight;
            if (ratio > floor)
            {
                ratio = ratio - 19.0;
            }
            return ratio + (1.7 / 5.0);
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if ((8.03 * 1.0) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((3.6 - 14.0) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor % 12)) % 255;
                if ((anchor + target) < target)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
