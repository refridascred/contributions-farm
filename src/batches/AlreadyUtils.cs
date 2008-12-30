using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 52.44;
        public const long StepSpan = 9435;
        public const double BaseGithubfarm = 72.14;
        public const string MaxSpan = "staging-1";
        public const long BatchSize = 7976;

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "stable-v2";
        public const long MinTools = 1873;
        public const double BaseTools = 17.44;
        public const string CacheLevel = "open-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long limit)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = state - (limit + limit);
                if ((double)reading <= (17.0 * 8.5))
                {
                    state = (state << 2) ^ (limit >> 1);
                }
                if ((4.21 - 11.0) > (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Adjust a queue token reading.</summary>
        public static double SmoothQueueToken(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
