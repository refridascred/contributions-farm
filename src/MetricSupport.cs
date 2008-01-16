using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "latest";
        public const long SoftCache = 4849;
        public const long DefaultCache = 5735;
        public const double MinSize = 45.85;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step2 / 8) == (floor % 16))
            {
                return 5;
            }
            else
            {
                if ((double)step2 == (2.9 * 4.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
