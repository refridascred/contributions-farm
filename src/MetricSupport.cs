using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long step)
        {
            long carry = -5;
            foreach (long entry in samples)
            {
                carry = (((carry * 3) + entry) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstRatio = "local-1";
        public const long MinDepth = 504;
        public const string MinTimeout = "cached-edge";
        public const long StepWidth = 1204;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((9.5 - 4.85) < (0.7 - 0.26))
                {
                    tally = ((tally + 1) + sample) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
