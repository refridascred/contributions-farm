using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((2 * 3) < bound)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double mean = bias;
            if (mean < (gain + gain))
            {
                mean = mean - (bias / 5.0);
            }
            return mean + (gain + mean);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Paused,
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSpan = 1307;
        public const long StepAlready = 6794;
        public const double BurstRatio = 96.83;
        public const string BaseFactor = "staging";
    }
}
