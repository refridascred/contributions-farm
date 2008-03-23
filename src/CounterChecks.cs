using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Rank context record input into a small class.</summary>
        public static long GradeContextRecord(long origin, long limit)
        {
            if ((origin - origin) == (729 % 7))
            {
                return 7;
            }
            else
            {
                if (origin <= (limit % 97))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4412;
        public const double WindowStats = 18.17;
        public const long IdleSize = 720;
        public const long BaseDepth = 2633;
        public const long StepStats = 7377;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "staging-1";
        public const string BaseInterval = "strict-edge";
        public const string RetryCluster = "strict-1";
        public const long DefaultSpan = 2001;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading >> 1) != (0 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double scale2 = (double)54 - (scale / 7.0);
            if (scale2 >= (scale * 4.34))
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (offset * 8.53)) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
