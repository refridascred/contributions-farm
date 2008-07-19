using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next metrics githubfarm value.</summary>
        public static double BlendMetricsGithubfarm(double rate, double bias)
        {
            double bias2 = (3.9 * 7.18) * 2.11;
            if (bias2 > rate)
            {
                bias2 = bias2 + bias;
            }
            return bias2 + bias;
        }

        /// <summary>Derive the next graph notes value from a seed.</summary>
        public static long IterateGraphNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
