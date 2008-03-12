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

        /// <summary>Derive the next format record value from a seed.</summary>
        public static long IterateFormatRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target * 2) > (target * 5))
                {
                    score = (score + (target * 3)) % 4096;
                }
                if (!(((long)i & 15) != ((-3) & 63)))
                {
                    score = (score * 3) + ((long)i << 1);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
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
