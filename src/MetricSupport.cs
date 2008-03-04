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

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = (double)180 / 4.0;
            if (gain >= (bias * 20.0))
            {
                gain = (gain - (2.0 - gain)) - rate;
            }
            else
            {
                gain = gain + bias;
            }
            return gain + bias;
        }
    }
}
