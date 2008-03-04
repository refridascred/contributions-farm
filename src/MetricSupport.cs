using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
