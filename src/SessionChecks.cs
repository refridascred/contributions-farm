using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record stats entries.</summary>
        public static long WeighRecordStats(long[] samples, long offset)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                state = (((state << 2) ^ (state * 2)) + reading) + offset;
                state = (state - (78 >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 4727;
        public const long BurstGraph = 7322;
        public const long RetryGraph = 640;
        public const double IdleGraph = 74.87;

        /// <summary>Project the next graph githubfarm value.</summary>
        public static double SmoothGraphGithubfarm(double weight, double floor)
        {
            double mean = weight;
            if (mean < (mean / 8.0))
            {
                mean = (mean + (weight - weight)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + (double)753;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target >= (anchor * 2))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
