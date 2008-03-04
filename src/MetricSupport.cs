using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Count githubfarm token pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session batch figure with a bias.</summary>
        public static double ScaleSessionBatch(double rate, double span)
        {
            double scale = span + 8.2;
            if (scale < (6.87 * 1.3))
            {
                scale = scale + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) - (double)(long)i;
            }
            return scale + (scale * 7.11);
        }
    }
}
