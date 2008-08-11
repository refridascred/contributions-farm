using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "primary-1";
        public const long LimitCount = 7298;
        public const string RetryTimeout = "legacy-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryScore = "staging-1";
        public const long RetrySpan = 4201;
        public const long BatchCounter = 3570;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry + (step * 3)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((bound + offset) < (offset - limit))
            {
                return 4;
            }
            else
            {
                if (((offset - bound) > (bound + limit)) || (limit > (limit + offset)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a session channel reading.</summary>
        public static double SmoothSessionChannel(double bias, double span)
        {
            double gain = (double)80 / 6.0;
            if (gain < (bias * 6.9))
            {
                gain = gain - (span * 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (bias / 6.0);
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double weight = (double)(159 + (-6));
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + bias;
        }
    }
}
