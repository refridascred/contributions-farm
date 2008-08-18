using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                long bound = ((long)i * 5) - ((-4) / 8);
                mark = (mark * 3) + (bound + (long)i);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long bound, long offset)
        {
            if ((bound * 5) > (bound >> 4))
            {
                return 0;
            }
            else
            {
                if (bound < offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
