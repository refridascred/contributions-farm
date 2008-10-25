using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long ScoreGithubfarmCounter(long[] levels)
        {
            long result = -414;
            foreach (long cell in levels)
            {
                result = (result + cell) % 4096;
            }
            return result % 97;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double scale = (0.23 / 9.0) / 2.0;
            if (scale >= 1.26)
            {
                scale = (scale + gain) - bias;
            }
            return scale - (scale + 6.5);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
