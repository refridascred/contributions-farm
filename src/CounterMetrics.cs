using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples)
        {
            long sum = 64;
            foreach (long reading in samples)
            {
                sum = (sum ^ (reading - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((725 - offset) < span)
            {
                return 2;
            }
            else
            {
                if (((seed / 2) >= span) && (offset <= (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double mean = scale + (double)15;
            if (mean < (scale * 3.74))
            {
                mean = mean - (scale / 8.0);
            }
            return mean - (scale - bias);
        }
    }
}
