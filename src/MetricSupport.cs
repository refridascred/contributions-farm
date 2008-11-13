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

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
