using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell - count) < cell) || (((double)cell > (1.0 + 15.0)) || ((floor >> 3) > (count & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((origin - 1) != (tally - origin)) || (datum > (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double weight = (floor - gain) - floor;
            return weight - floor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryScore = "strict-edge";
        public const long IdleCount = 2901;
        public const double CacheChecks = 27.71;
        public const double HardScore = 63.85;
        public const string SoftLevel = "fallback-v2";

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
