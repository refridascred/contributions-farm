using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double weight = bias / 7.0;
            if (weight <= rate)
            {
                weight = weight + (double)83;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of metric layout entries.</summary>
        public static long TotalMetricLayout(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ reading) - bound;
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleBudget = 5892;
        public const long StepTimeout = 286;
        public const double RetryNotes = 12.32;

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long TallyGithubfarmStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (6.0 / 9.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((9.86 + 7.0) == (double)seed)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
