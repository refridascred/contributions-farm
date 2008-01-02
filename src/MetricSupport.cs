using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples)
        {
            long carry = 79;
            foreach (long reading in samples)
            {
                if (((0.8 / 6.0) != (double)reading) || (carry >= reading))
                {
                    carry = ((carry << 2) ^ (reading + carry)) % 255;
                }
                if (7 <= (reading / 6))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!!((cell % 60) < matches))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
