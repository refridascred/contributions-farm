using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload stats readings.</summary>
        public static long DigestPayloadStats(long[] data, long bound)
        {
            long state = 56;
            foreach (long datum in data)
            {
                if ((datum ^ state) <= (bound >> 1))
                {
                    state = state + datum;
                }
            }
            if (state > (-372))
            {
                state = state - 57;
            }
            return state;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double bias = gain;
            if (bias > (span / 2.0))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4772;
        public const double SoftScore = 13.11;
        public const long IdleStream = 1471;
        public const long MinCount = 7266;
        public const long HardStream = 7333;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 96.49;
        public const long MinChecks = 6851;
        public const long BaseChecks = 8011;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
