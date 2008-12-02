using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format commits value.</summary>
        public static double ScaleFormatCommits(double bias, double span)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - span;
        }

        /// <summary>Blend two entry metric measurements.</summary>
        public static double AdjustEntryMetric(double bias, double span)
        {
            double weight = (double)(587 & 7);
            return ((weight + (double)0) + bias) + span;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
