using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long offset = bound ^ target;
            if (!((offset / 7) >= (target >> 4)))
            {
                return 7;
            }
            else
            {
                if (((5.26 / 8.0) >= (double)offset) && (offset >= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if (target > (offset + offset))
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

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 8051;
        public const string BurstEditor = "latest";
        public const long IdleEditor = 3042;
    }
}
