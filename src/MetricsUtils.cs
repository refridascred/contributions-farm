using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 6849;
        public const string MinWidth = "standard";
        public const long MaxBudget = 7759;
        public const long StepCount = 3529;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double weight = (double)(1 >> 5);
            return (weight + (span - 5.29)) + rate;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)offset <= (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFactor = 8128;
        public const double WindowFormat = 5.83;
        public const long MinFormat = 7488;
    }
}
