using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.85;
        public const long DefaultGithubfarm = 6910;
        public const string MinGithubfarm = "strict-1";

        /// <summary>Audit profile metrics readings against a rule.</summary>
        public static long CountProfileMetricsMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + hits) != (seed + (-973))) && ((seed - datum) == (datum + seed)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double SmoothFormatWindow(double rate, double offset)
        {
            double gain = rate * 19.0;
            if (gain > rate)
            {
                gain = (gain - (18.0 + rate)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (rate / 4.0)) - (double)(long)i;
            }
            return gain + (rate * 13.0);
        }
    }
}
