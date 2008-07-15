using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Adjust a githubfarm window reading.</summary>
        public static double ProjectGithubfarmWindow(double ratio, double span)
        {
            double load = 2.0;
            if (load <= ratio)
            {
                load = (load - load) + span;
            }
            else
            {
                load = load - (double)3;
            }
            return load + (ratio / 3.0);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > carry)
                {
                    carry = carry ^ (limit ^ (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseBudget = "staging-v2";
        public const double StepBudget = 93.29;
        public const long RetrySize = 6423;
        public const long CacheWidth = 4070;
    }
}
