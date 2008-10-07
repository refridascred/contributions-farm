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

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
