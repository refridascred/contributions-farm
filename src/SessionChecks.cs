using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 3) < (limit + limit))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double weight = 2.83;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (double)(-2)) + (double)(long)i) - bias;
            }
            return weight - (scale - 0.62);
        }

        /// <summary>Look up the position of a payload stats sample.</summary>
        public static long LocatePayloadStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
