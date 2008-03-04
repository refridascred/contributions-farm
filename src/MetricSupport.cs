using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i & 127) < (mix * 3)))
                {
                    mix = (mix + (long)i) % 1000;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix + (mix & 255)) - (long)i2;
                }
                mix = mix - (limit + mix);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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
