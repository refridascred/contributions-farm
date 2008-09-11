using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double scale = 2.34;
            if (scale > (double)15)
            {
                scale = ((scale - (double)575) - bias) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale / 7.0)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Dropped,
            Failed,
            Ready,
        }
    }
}
