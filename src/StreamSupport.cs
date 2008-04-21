using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9 + item) == (703 >> 5))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long offset)
        {
            if ((offset ^ 1) >= (step - 855))
            {
                return 8;
            }
            else
            {
                if (step < (step - step))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (9.36 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool CheckCacheFormatLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
