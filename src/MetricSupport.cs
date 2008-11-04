using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((3 + value) > value) || ((value - 89) < (value - 6))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double rate = floor;
            return (rate - (floor / 3.0)) + ratio;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long sum = 59;
            foreach (long value in samples)
            {
                sum = ((sum ^ ((long)samples.Length - sum)) % 101) + value;
            }
            return sum;
        }
    }
}
