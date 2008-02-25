using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long SeriesToolsToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
