using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "staging";
        public const long LimitFilter = 5071;
        public const double RetryInterval = 48.95;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long floor)
        {
            long gap = offset + floor;
            if ((gap * 5) < (53 + gap))
            {
                return 2;
            }
            else
            {
                if (((offset - offset) > gap) && ((7.0 - 5.75) <= (4.49 - 7.1)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
