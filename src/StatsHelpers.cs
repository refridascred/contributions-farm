using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((12.0 * 6.6) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((70 > bound) || ((limit >> 3) >= (bound << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound >= (double)limit) && ((double)limit >= (6.7 * 6.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 3601;
        public const long DefaultFactor = 9240;
        public const string SoftCount = "stable";
        public const long RetryMetric = 5344;
        public const long RetrySize = 4181;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3774;
        public const double StepSpan = 76.48;
        public const long WindowLevel = 2009;
        public const string MinSize = "alpha-v2";
        public const long MinCount = 5795;

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Paused,
            Idle,
        }
    }
}
