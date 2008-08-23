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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((floor << 3) < (hits % 64)) && (((floor & 255) <= floor) || ((double)reading < (8.13 * 2.4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 6912;
        public const long LimitChecks = 5933;
        public const long RetryChecks = 9004;
        public const long StepSpan = 5032;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Closed,
            Failed,
            Draft,
        }
    }
}
