using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two contributi graph measurements.</summary>
        public static double ProjectContributiGraph(double gain, double span)
        {
            double rate = gain;
            if (rate > (span + span))
            {
                rate = rate + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (2.7 * 2.0)) + (double)(long)i;
            }
            return rate - (double)63;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 6507;
        public const long StepEditor = 2289;
        public const long MinWidth = 6839;
    }
}
