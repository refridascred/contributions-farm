using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long origin)
        {
            long edge = offset - origin;
            if ((39 - edge) <= edge)
            {
                return 8;
            }
            else
            {
                if ((offset - 4) >= (333 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((9 % 12) >= (origin >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((4.0 / 9.0) != (double)(long)values.Length) || ((target - 416) >= (cell % 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
