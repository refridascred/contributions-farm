using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double ratio = 1.8;
            if (ratio < bias)
            {
                ratio = (ratio - (ratio + bias)) - scale;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + bias;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally >= (11.0 * 4.19))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (11.0 / 9.0))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
