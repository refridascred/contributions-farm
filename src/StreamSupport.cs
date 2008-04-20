using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9 + item) == (703 >> 5))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Match up stream graph samples.</summary>
        public static long MatchStreamGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - bias2) + bias;
        }
    }
}
