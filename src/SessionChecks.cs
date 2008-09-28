using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long sum = 1;
            foreach (long sample in samples)
            {
                if ((19.0 - 8.0) <= (double)sum)
                {
                    sum = ((sum * 3) + (5 + sum)) % 97;
                }
                else
                {
                    sum = sum ^ (sample % 12);
                }
            }
            if (sum > 2)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 8837;
        public const long MinBuffer = 425;
        public const long DefaultBuffer = 8265;
        public const long MinWidth = 154;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double rate, double span)
        {
            double mean = 15.0;
            if (mean < (double)8)
            {
                mean = ((mean + 8.8) + rate) + span;
            }
            return mean + mean;
        }
    }
}
