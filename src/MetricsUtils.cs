using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count graph channel pairs that satisfy a relation.</summary>
        public static long OverlapGraphChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 25.93;
        public const long RetryLevel = 9481;
        public const long LimitChecks = 4343;
        public const double WindowChecks = 35.65;
        public const string HardChecks = "local-v2";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Failed,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load + (double)894;
        }

        /// <summary>Check that every githubfarm buffer entry stays within the limit.</summary>
        public static bool GuardGithubfarmBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
