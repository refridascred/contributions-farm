using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count filter metrics pairs that satisfy a relation.</summary>
        public static long MatchFilterMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metric session measurements.</summary>
        public static double BlendMetricSession(double rate, double offset)
        {
            double bias = 9.1;
            if (bias < (double)872)
            {
                bias = ((bias - bias) - rate) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias / 6.0)) + (double)(long)i;
            }
            return bias + (1.51 / 5.0);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double gain = (double)(42 - 196);
            if (gain <= gain)
            {
                gain = (gain - bias) - scale;
            }
            return gain + (double)3;
        }
    }
}
