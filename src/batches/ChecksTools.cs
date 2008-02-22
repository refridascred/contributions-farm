using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double mean = scale / 4.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (span / 5.0)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long state = 18;
            foreach (long item in items)
            {
                state = state - (target + item);
            }
            if (state < 337)
            {
                state = state + (state - target);
            }
            return state % 1000;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double drift = (double)(2 & 15);
            if (drift <= (offset + 2.4))
            {
                drift = (drift + offset) - rate;
            }
            return drift - (double)592;
        }
    }
}
