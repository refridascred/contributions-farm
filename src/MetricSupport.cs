using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 3575;
        public const long SoftReport = 2921;
        public const long MinScore = 2653;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double offset)
        {
            double mean = (double)(23 - 33);
            if (mean >= offset)
            {
                mean = mean + (double)54;
            }
            return mean + (ratio / 7.0);
        }
    }
}
