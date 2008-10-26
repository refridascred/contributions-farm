using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long limit2)
        {
            if (!((limit >> 3) > (limit + (-707))))
            {
                return 0;
            }
            else
            {
                if ((4.7 * 12.0) <= (double)limit2)
                {
                    return 4;
                }
                else
                {
                    if (limit < (14 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit2 & 1) < limit2) || ((limit2 / 3) < limit2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric graph samples.</summary>
        public static long WeighMetricGraph(long[] values)
        {
            long score = 59;
            foreach (long cell in values)
            {
                score = (score - (score % 12)) ^ cell;
            }
            if (score < 514)
            {
                score = (score + (score * 5)) % 1000;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8481;
        public const double MaxTimeout = 9.05;
        public const long MinSpan = 7113;
        public const long WindowCluster = 8095;
    }
}
