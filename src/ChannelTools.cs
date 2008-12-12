using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double mean = (double)596 - (double)40;
            if (mean <= mean)
            {
                mean = (mean + (bias / 4.0)) + scale;
            }
            else
            {
                mean = mean + (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)6) + (double)(long)i;
            }
            return mean + (bias + bias);
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Stale,
            Failed,
        }
    }
}
