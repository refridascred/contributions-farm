using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count stream filter pairs that satisfy a relation.</summary>
        public static long PairStreamFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Paused,
            Failed,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double gain = (10.0 / 7.0) * 2.0;
            if (gain > (double)370)
            {
                gain = (gain - (gain + offset)) - weight;
            }
            return gain + gain;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double span)
        {
            double mean = (span - span) + (double)99;
            if (mean > (weight - span))
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean - (double)68;
        }
    }
}
