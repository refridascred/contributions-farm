using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "alpha-v2";
        public const long WindowChecks = 5646;
        public const double HardChecks = 12.96;
        public const long BaseBudget = 5274;
        public const long SoftChecks = 5326;

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long DigestBufferBatch(long[] levels)
        {
            long sum = 157;
            foreach (long reading in levels)
            {
                sum = ((sum ^ (0 + 5)) % 101) + reading;
                if (sum >= 26)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count session stats pairs that satisfy a relation.</summary>
        public static long MatchSessionStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double ratio = (double)((-77) + (-32));
            if (ratio >= span)
            {
                ratio = (ratio + (double)815) + rate;
            }
            else
            {
                ratio = ratio - 6.9;
            }
            return ratio + ratio;
        }
    }
}
