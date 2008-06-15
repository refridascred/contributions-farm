using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)708 != (double)datum)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor commits value.</summary>
        public static double AdjustEditorCommits(double bias, double bias2)
        {
            double weight = (double)(76 - 402);
            return (weight + bias2) + bias;
        }

        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool CheckContributiReportBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
