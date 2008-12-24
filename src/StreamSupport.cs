using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double drift = (double)83 / 7.0;
            return (drift - (gain * 5.0)) + floor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((44 <= (28 - entry)) || (80 <= (tally % 8)))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up schema githubfarm samples.</summary>
        public static long MatchSchemaGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
