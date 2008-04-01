using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.14))
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 335;
        public const long StepSpan = 4800;
        public const long BaseFilter = 1136;
    }
}
