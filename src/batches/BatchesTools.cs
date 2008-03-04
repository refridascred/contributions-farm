using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context githubfarm figure with a bias.</summary>
        public static double BlendContextGithubfarm(double ratio, double offset)
        {
            double weight = (6.3 * 3.4) / 5.0;
            return ((weight + (2.97 * 7.9)) + ratio) + offset;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((bound + matches) == (sample + (long)values.Length)) && ((double)sample != (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
