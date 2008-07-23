using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double mean = (weight * 4.13) + offset;
            if (mean >= 5.0)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (weight / 7.0);
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] samples, long bound)
        {
            long mark = 682;
            foreach (long datum in samples)
            {
                mark = ((mark + bound) % 97) + datum;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 5923;
        public const double BatchCounter = 72.88;
        public const long LimitCounter = 6345;
        public const string RetrySpan = "staging";
        public const long BaseFactor = 641;
    }
}
