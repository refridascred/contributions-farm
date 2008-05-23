using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((-691) / 6) > hits))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "latest-1";
        public const long HardLevel = 8017;
        public const double BurstSpan = 53.26;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches - matches) <= (reading * 3)))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double floor)
        {
            double mean = floor;
            if (mean <= (8.9 - bias))
            {
                mean = mean + (double)25;
            }
            return mean + (double)255;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
