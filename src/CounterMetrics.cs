using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a metrics githubfarm counter forward.</summary>
        public static long StepMetricsGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((14.0 / 8.0) > (double)entry) && ((double)seen < 18.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 6912;
        public const long LimitChecks = 5933;
        public const long RetryChecks = 9004;
        public const long StepSpan = 5032;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!((11.0 - 3.39) <= (double)reading))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
